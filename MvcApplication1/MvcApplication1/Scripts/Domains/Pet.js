var Pet = function (name, legs) {
    this.name = name; // Save the name and legs values.
    this.legs = legs;
};

// Create a method that shows the Pet's name and number of legs.
Pet.prototype.getDetails = function () {
    return this.name + ' has ' + this.legs + ' legs';
};

// Define a Cat object, inheriting from Pet.
var Cat = function (name) {
    Pet.call(this, name, 4); // Call the parent object's constructor.
};

// This line performs the inheritance from Pet.
Cat.prototype = new Pet();

// Augment Cat with an action method.
Cat.prototype.action = function () {
    return 'Catch a bird';
};