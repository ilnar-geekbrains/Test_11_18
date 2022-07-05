
// Рекурсивная функция копирования объектов (к которым относятся и массивы)
const deepCloneVariable = variable => {
    // Примитивные типы данных не копируются по ссылке, так что просто возвращаем их
    if (typeof variable !== 'object') return variable
    // Официальный призннанный баг движка JS (typeof null равно 'object')
    // Так что для null здесь отдельная проверка
    if (variable === null) return null;
    // Создаем поверхностный (плоский) клон оригинала
    let surfaceСlone = Object.assign({}, variable);

    // Определяем, какие пары ключ-значение необходимо глубоко клонировать
    Object.keys(surfaceСlone).forEach(
        key =>
        (surfaceСlone[key] =
            typeof variable[key] === "object" ? deepCloneVariable(variable[key]) : variable[key])
            // Собственно тут и происходит рекурсия
            // Углубление в объект идет до тех пор, пока  typeof variable[key] === "object"
    );

    // Проверяем является ли variable массивом и не пустой ли он
    return Array.isArray(variable) && variable.length
        // Если variable массив и он не пуст, тогда
        // указываем объекту surfaceСlone длину исходного массива что бы
        // конвертировать surfaceСlone в массив и вернуть его
        ? (surfaceСlone.length = variable.length) && Array.from(surfaceСlone)
        // Если variable пустой массив,
        : Array.isArray(variable)
            // то возвращаем его
            ? Array.from(variable)
            // в других случаях variable это объект и мы возвращаем копию surfaceСlone.
            : surfaceСlone;
};
