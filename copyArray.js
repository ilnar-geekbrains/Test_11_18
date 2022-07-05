

const deepCloneVariable = variable => {
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
    // Дальше нужна проверка для массива и возврат surfaceСlone
};
