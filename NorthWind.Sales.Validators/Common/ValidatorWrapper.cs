namespace NorthWind.Sales.Validators.Common
{
    public abstract class ValidatorWrapper<T> :
        AbstractValidator<T>,
       Entities.Interfaces.IValidator<T>
    {
        public IEnumerable<KeyValuePair<string, string>> Failures
        { get; private set; }

        public async new ValueTask<bool> Validate(T instanceToValidate)
        {
            var Result = await ValidateAsync(instanceToValidate);

            if (!Result.IsValid)
            {
                Failures = Result.Errors
                    .Select(e =>
                    new KeyValuePair<string, string>(
                        e.PropertyName, e.ErrorMessage)).ToList();
            }
            return Result.IsValid;
        }
    }
}
