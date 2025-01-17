// smelly
const wifePhoneNumber = "+380638976512";
const friendPhoneNumber = "+380955671274";

// not so smelly
// const wifePhoneNumber = new PhoneNumber("+38", "0638976512");
// const friendPhoneNumber = new PhoneNumber("+38", "0955671274");


class PhoneNumber
{
  #countryCode;
  #number;

  constructor(countryCode, number)
  {
    this.#countryCode = countryCode;
    this.#number = number;
  }

  toString() {
    return `${this.#countryCode}${this.#number}`;
  }
}