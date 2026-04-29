//1
function removeDuplicatesAndCount(arr) {
    const uniqueElements = [...new Set(arr)];
    const duplicateCount = arr.length - uniqueElements.length;
    
    console.log("Unikal Array:", uniqueElements);
    console.log("Təkrar olunan elementlərin sayı:", duplicateCount);
    
    return uniqueElements;
}

const ededler = [1, 2, 3, 2, 4, 1, 5, 6, 5];
removeDuplicatesAndCount(ededler);



//2
function isPalindrome(str) {
    
    const cleanStr = str.toLowerCase().replace(/[^a-z0-9]/g, '');
    const reversedStr = cleanStr.split('').reverse().join('');
    
    return cleanStr === reversedStr;
}

console.log(isPalindrome("Radar"));



//3
function countSmallerElements(arr, num) {
    let count = 0;
    for (let i = 0; i < arr.length; i++) {
        if (num < arr[i]) {
            count++;
        }
    }
    return count;
}

const arr = [1, 5, 8, 2, 10];
const num = 4;
console.log(countSmallerElements(arr, num)); 



//4
function checkAbundantOrDeficient(n) {
    let sum = 0;
    for (let i = 1; i < n; i++) {
        if (n % i === 0) {
            sum += i;
        }
    }
    
    if (sum > n) {
        return `${n} - Abundant (Bol) ədəddir. (Bölənlərin cəmi: ${sum})`;
    } else {
        return `${n} - Deficient (Qıt) ədəddir. (Bölənlərin cəmi: ${sum})`;
    }
}

console.log(checkAbundantOrDeficient(12)); 
console.log(checkAbundantOrDeficient(13)); 




//5
function squareArray(arr) {
    return arr.map(item => item * item);
}

const originalArray = [1, 2, 3, 4, 5];
const squaredArray = squareArray(originalArray);
console.log(squaredArray); 
