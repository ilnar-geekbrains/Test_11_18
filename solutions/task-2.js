// произведение массивов

function polynomial(first, second) {
	let res = [];

	for (let i = 0; i < first.length; i++) {
		for (let j = 0; j < second.length; j++) {
			if (res[i + j]) {
				res[i + j] = res[i + j] + first[i] * second[j];
			} else {
				res[i + j] = first[i] * second[j];
			}
		}
	}

	return res;
}

console.log(polynomial([-1, 1], [2, 1])); // [-2, 1, 1]

