// LAUNCH TESTS

const unitTestHolder = new Set();

addPolynomUnitTests(unitTestHolder);

runPolynomsUnitTests(unitTestHolder);

// UNIT TESTS

function addPolynomUnitTests(unitTestHolder) {
    unitTestHolder.add(() => {
        const res = multiplyPolynom(true, 1);
        if(res) {
            console.error('FAILED: shouldnt work with bad arguments');
            return;
        }
        console.info('PASSED: shouldnt work with bad arguments');
    })
    
    unitTestHolder.add(() => {
        const res = multiplyPolynom([true], ['h', 6]);
        if(res) {
            console.error('FAILED: shouldnt work with bad arguments');
            return;
        }
        console.info('PASSED: shouldnt work with bad arguments');
    })
    
    unitTestHolder.add(() => {
        const res = multiplyPolynom([], []);
        if(res) {
            console.error('FAILED: shouldnt work with bad arguments');
            return;
        }
        console.info('PASSED: shouldnt work with bad arguments');
    })

    unitTestHolder.add(() => {
        const res = multiplyPolynom([-1, 1], [2, 1]);
        if(JSON.stringify(res) != JSON.stringify([-2, 1, 1])) {
            console.error('FAILED: should be [-2, 1, 1], but atcual is ', res);
            return;
        }
        console.info('PASSED: gave correct answer');
    })

    unitTestHolder.add(() => {
        const res = multiplyPolynom([5, 0, 10, 6], [1, 2, 4]);
        if(JSON.stringify(res) != JSON.stringify([5, 10, 30, 26, 52, 24])) {
            console.error('FAILED: should be [5, 10, 30, 26, 52, 24], but atcual is ', res);
            return;
        }
        console.info('PASSED: gave correct answer');
    })
    unitTestHolder.add(() => {
        const res = multiplyPolynom([10], [10]);
        if(JSON.stringify(res) != JSON.stringify([100])) {
            console.error('FAILED: should be [100], but atcual is ', res);
            return;
        }
        console.info('PASSED: gave correct answer');
    })

    unitTestHolder.add(() => {
        const res = multiplyPolynom([0, 0, 0], [0, 10]);
        if(JSON.stringify(res) != JSON.stringify([0])) {
            console.error('FAILED: should be [0], but atcual is ', res);
            return;
        }
        console.info('PASSED: gave correct answer');
    })

    unitTestHolder.add(() => {
        const res = multiplyPolynom([0, 0, 0, 0, 0, 2, 0, 0], [0, 0, 0, 0, 2, 1, 0, 0]);
        if(JSON.stringify(res) != JSON.stringify([0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 2])) {
            console.error('FAILED: should be [0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 2], but atcual is ', res);
            return;
        }
        console.info('PASSED: gave correct answer');
    })

    unitTestHolder.add(() => {
        const res = multiplyPolynom([3, 0, 0, 0, 0], [-1, 0, 0, 0, 0, 0, 0, 0]);
        if(JSON.stringify(res) != JSON.stringify([-3])) {
            console.error('FAILED: should be [-3], but atcual is ', res);
            return;
        }
        console.info('PASSED: gave correct answer');
    })
}

function runPolynomsUnitTests(unitTestHolder) {
    unitTestHolder.forEach(func => func())
}

// TASK2
function multiplyPolynom(arrPolynom1, arrPolynom2) {
    if (!passValidationPolynom(arrPolynom1, arrPolynom2)) {
        console.error('Wrong arguments');
        return;
    }
    resultPolynomArr = makePolynomMultiplicatuion(arrPolynom1, arrPolynom2);
    resultPolynomArr = removeRightZeros(resultPolynomArr);
    return resultPolynomArr;
}

function passValidationPolynom(arrPolynom1, arrPolynom2) {
    if(!Array.isArray(arrPolynom1) || !Array.isArray(arrPolynom2)) {
        return false;
    }
    if(!arrPolynom1.length || !arrPolynom2.length) {
        return false;
    }
    const notNumberInPolynom1 = arrPolynom1.find(value => typeof value !== "number")
    const notNumberInPolynom2 = arrPolynom2.find(value => typeof value !== "number")
    if(notNumberInPolynom1 || notNumberInPolynom2) {
        return false;
    }
    return true;
}

function createAndResetResultPolynom(arrPolynom1, arrPolynom2) {
    return new Array(arrPolynom1.length + arrPolynom2.length - 1).fill(0);
}

function makePolynomMultiplicatuion(arrPolynom1, arrPolynom2) {
    const resultPolynomArr = createAndResetResultPolynom(arrPolynom1, arrPolynom2);;
    for(let i = 0; i<arrPolynom1.length; i++) {
        for(let j = 0; j< arrPolynom2.length; j++) {
            resultPolynomArr[i+j]= resultPolynomArr[i+j] + arrPolynom1[i]*arrPolynom2[j];
        }
    }
    return resultPolynomArr;
}

function removeRightZeros(resultPolynomArr) {
    const noZeroIndex = findNoZeroIndex(resultPolynomArr);
    if(noZeroIndex === resultPolynomArr.length - 1) {
        return resultPolynomArr;
    }
    if(noZeroIndex === undefined) {
        return [0];
    }
    return resultPolynomArr.filter((value, index) => index <= noZeroIndex);
}

function findNoZeroIndex(resultPolynomArr) {
    let noZerondex = undefined;
    for(let i=resultPolynomArr.length - 1;i>=0;i--) {
        if(resultPolynomArr[i]) {
            noZerondex = i;
            break;
        }
    }
    return noZerondex;
}
