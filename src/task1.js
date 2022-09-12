const deepClone = input => {
        if (typeof input !== 'object') return input;
        const output = Array.isArray(input) ? [] : {};
        const keys = Object.keys(input);
        keys.forEach(key => {
            output[key] = deepClone(input[key]);
        });
        return output;
    };

let originalArray = [37, 3700, { hello: "world" }]
console.log("Original array:", ...originalArray) // 37 3700 Object { hello: "world" }

let shallowCopiedArray = originalArray.slice() // for shallow copy i e when elements are primitives only 
let deepCopiedArray = deepClone(originalArray)
