// // Codewars KATA 2023 02 17
// function narcissistic(value) {
//   value = String(value);
//   let s = 0;
//   for (const digit of value) {
//     s += Number(digit) ** value.length;
//   }
//   return s === Number(value) ? true : false;
// }
// console.log(narcissistic(7));
// console.log(narcissistic(371));
// console.log(narcissistic(700));

// ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 18 - https://www.codewars.com/kata/556deca17c58da83c00002db
// function tribonacci(signature, n) {
//   //   Guard clauses
//   if (n === 0) return [];
//   if (n === 1) return [signature[0]];
//   if (n === 2) return [signature[0], signature[1]];
//   if (n === 3) return signature;

//   const triboLst = [...signature];

//   for (let idx = 0; idx < n - 4; idx++) {
//     let sumOf3 = 0;

//     // Looping from the back, 3 element of the lst
//     for (idx = triboLst.length - 1; idx >= triboLst.length - 3; idx--) {
//       sumOf3 += triboLst[idx];
//     }
//     // console.log(sumOf3);
//     triboLst.push(sumOf3);
//   }
//   return triboLst;
// }

// console.log(tribonacci([1, 1, 1], 5));

// ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 18 - https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
// function accum(s) {
//   let fullStr = "";
//   s = s.toLowerCase();
//   for (let i = 0; i < s.length; i++) {
//     // console.log(i, s[i]);
//     fullStr += s[i].toUpperCase();

//     // instead of this:
//     // for (let j = 0; j < i; j++) {
//     //   fullStr += s[i];
//     // }

//     // use this:
//     fullStr += s[i].repeat(i);

//     i + 2 > s.length ? "" : (fullStr += "-");
//   }
//   return fullStr;
// }

// console.log(accum("aBcDE"));

// ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 20 - https://www.codewars.com/kata/578553c3a1b8d5c40300037c
// const binaryArrayToNumber = (arr) => {
//   let decimal = 0;
//   arr.reverse().forEach((el, i) => {
//     decimal += el * 2 ** i;
//     // console.log(el, i);
//   });
//   return decimal;
// };

// console.log(binaryArrayToNumber([1, 0, 1, 0, 1]));

// // ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 21 - https://www.codewars.com/kata/585d7d5adb20cf33cb000235
// function findUniq(arr) {
//   if (arr[0] !== arr[1] && arr[0] !== arr[2]) return arr[0];
//   if (arr[0] !== arr[1] && arr[1] !== arr[2]) return arr[1];

//   let res = arr[0];
//   for (let i = 0; i < arr.length - 1; i++) {
//     if (res !== arr[i + 1]) {
//       res = arr[i + 1];
//       break;
//     }
//   }
//   return res;
// }

// console.log(findUniq([1, 8, 1, 1, 1, 1, 9]));

// // ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 23 - https://www.codewars.com/kata/514b92a657cdc65150000006
// function solution(number) {
//   let sum = 0;
//   for (let i = 0; i < number; i++) {
//     i % 3 === 0 || i % 5 === 0 ? (sum += i) : "";
//   }
//   return sum;
// }

// console.log(solution(10));

// // ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 27 - https://www.codewars.com/kata/52449b062fb80683ec000024
// function generateHashtag(str) {
//   if (str.trim().length === 0) return false;

//   let final = "";
//   str.split(" ").forEach((el) => {
//     if (el.trim().length === 0) return;
//     final += el[0].toUpperCase();
//     final += el.slice(1);
//   });

//   if (final.length >= 140) return false;

//   if (final[0] === "#") return final;

//   return "#" + final;
// }

// console.log(generateHashtag("code" + " ".repeat(140) + "wars"));

// // ----------------------------------------------------------------------------------------------------------------------------
// // Codewars KATA 2023 02 28 FAILED - couldn't find the solution without help - https://www.codewars.com/kata/52774a314c2333f0a7000688
function validParentheses(parens) {
  var n = 0;
  for (var i = 0; i < parens.length; i++) {
    if (parens[i] == "(") n++;
    if (parens[i] == ")") n--;
    if (n < 0) return false;
  }

  return n == 0;
}
