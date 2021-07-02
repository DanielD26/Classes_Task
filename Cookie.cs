using System;

namespace ClassesTask {
    // Task 1.1
    class Cookie : Colour {
        public int Weight;
        public string Shape;

        // Task 1.4
        public Cookie(int weight, string shape, string name) : base (name){
            this.Weight = weight;
            this.Shape = shape;
        }
    }
}