function filterNumbers (array, operation) {
    const filteredArray = [];
    for (let i = 0; i < array.length; i++) {
        if (operation(array[i])) {
            filteredArray.push(array[i]);
        }
    }
    return filteredArray;
}

function isEven (value) {
    return value % 2 === 0;
}

const nums = [];

for (let i = 0; i < 20; i++) {
      nums.push(Math.floor(Math.random() * 20));
}

const evenNums = filterNumbers(nums, isEven);
console.log(evenNums);

