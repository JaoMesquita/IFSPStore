using AutoMapper;
using FluentValidation;
using IFSPStore.Domain.Base;
using Microsoft.IdentityModel.Tokens.Experimental;
using System.Runtime.CompilerServices;


namespace IFSPStore.Service.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IBaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;
        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputmodel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : FluentValidation.AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputmodel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Insert(entity);
            var outputmodel = _mapper.Map<TOutputModel>(entity);
            return outputmodel;
        }

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Objeto nulo!");
            }
            validator.ValidateAndThrow(obj);
        }

        public void AttachObeject(object obj)
        {
            _baseRepository.AttachObject(obj);
        }

        public void Delete(int id)
        {
            _baseRepository.CleanChangeTracker();
            _baseRepository.Delete(id);

        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(IList<string> oncludes = null) where TOutputModel : class
        {
            var entities = _baseRepository.Select(oncludes);
            return entities.Select(s => _mapper.Map<TOutputModel>(s)).ToList();
        }

        public TOutputModel GetById<TOutputModel>(int id, IList<string> includes = null) where TOutputModel : class
        {
            var entities = _baseRepository.Select(id, includes);
            return _mapper.Map<TOutputModel>(entities);
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputmodel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : FluentValidation.AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputmodel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Update(entity);
            return _mapper.Map<TOutputModel>(entity);
        }
    }
}