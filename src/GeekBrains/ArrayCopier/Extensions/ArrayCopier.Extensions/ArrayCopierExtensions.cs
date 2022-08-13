using ArrayCopier.Logic;
using ArrayCopier.Logic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ArrayCopier.Extensions
{
    /// <summary>
    /// Расширение для контекста ArrayCopier
    /// </summary>
    public static class ArrayCopierExtensions
    {
        /// <summary>
        /// Добавление и регистрация сервисов контекста ArrayCopier
        /// </summary>
        public static IServiceCollection AddArrayCopierServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            // Регистрация сервиса копирования массивов
            services.AddScoped<IArrayCopierService, ArrayCopierService>();

            return services;
        }
    }
}
