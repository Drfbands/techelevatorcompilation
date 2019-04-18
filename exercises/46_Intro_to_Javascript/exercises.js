//1.)
function sumDouble(x,y){
    if(x===y){
        return (x + y) * 2; 
    }

    return x+y; 
};

sumDouble(2,2);
sumDouble(1,2);
sumDouble(3,2);

//2.) 

function hasTeen(x,y,z){
 
    if(x >= 13 && x <= 19 || y >= 13 && y <= 19 || z >= 13 && z <= 19 ){
        return true;
    }
    
    return false; 
}
// could refactor this to a bool
hasTeen(13, 20, 10) 
hasTeen(20, 19, 10) 
hasTeen(20, 10, 13)



//3.)
function lastDigit(a, b){

  a =  a.toString().slice(-1);
  b =   b.toString().slice(-1);

  if(a == b){
      return true; 
  }
  else {
      return false;
  }
}
lastDigit(7, 17) 
lastDigit(6, 17)
lastDigit(3, 113)

//4.)
function seeColor(str){
    

   if(str.indexOf('red') == 0){
       return 'red';
   }    
   else if(str.indexOf("blue") == 0){
       return 'blue';
   }
  else {
    return ''; 
  } 
};

seeColor("redxx")
seeColor("xxred") 
seeColor("blueTimes") 

//5.) 
function oddOnly(numbersToFilter){
    return  numbersToFilter.filter((number) => {
        return number % 2 === 1;
      });

}
oddOnly([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11])
oddOnly([2, 4, 8, 32, 256])

//6.) 
function frontAgain(word) {
  let front = word.substring(0,2);
  let end = word.substring(-2, 2);  
  if(front == end){
      return true;
  }
  else {
    return false; 
  }
     
}
frontAgain("edited") 
frontAgain("edit") 
frontAgain("ed") 

// 7.)
function cigarParty(numberOfCigars, weekend){

    partySuccess = ((numberOfCigars >= 40 && numberOfCigars <= 60 && weekend == false) || (numberOfCigars >= 40 && weekend == true))
    return partySuccess;
}

cigarParty(30, false) 
cigarParty(50, false)
cigarParty(70, true) 

//8.) 
function fizzBuzz(number)
{
   
       if(number % 3 == 0 && number % 5 == 0)
       {
           return "FizzBuzz";
       }
       else if(number % 3 == 0)
       {
            return "Fizz";
       }
       else if(number % 5 == 0)
       {
           return "Buzz";
       }
       else
       {
           return number;
       }
}


fizzBuzz(3) 
fizzBuzz(1) 
fizzBuzz(10) 
fizzBuzz(15) 
fizzBuzz(8) 
//9.) 
function filterEvens(nums){
    return  nums.filter((number) => {
        return number % 2 === 0;
      });
    
}
filterEvens([]) 
filterEvens([1, 3, 5]) 
filterEvens([2, 4, 6])
filterEvens([100, 8, 21, 24, 62, 9, 7])

//10.) 
function filterBigNumbers(nums){
    return  nums.filter((number) => {
        return number >= 100;
      });
}

filterBigNumbers([7, 10, 121, 100, 24, 162, 200]) 
filterBigNumbers([3, 2, 7, 1, -100, -120]) 
filterBigNumbers([])

//11.)
function filterMultiplesOfX(nums, mod){
    return  nums.filter((number) => {
        return number % mod === 0;
});
}
filterMultiplesOfX([3, 5, 1, 9, 18, 21, 42, 67], 3) 
filterMultiplesOfX([3, 5, 10, 20, 18, 21, 42, 67], 5)

//12.) 
function createObject(){
    const person = {
        firstName: "Michael",
        lastName: "Jackson",
        age: 52,
    }
    return person;
}

createObject();