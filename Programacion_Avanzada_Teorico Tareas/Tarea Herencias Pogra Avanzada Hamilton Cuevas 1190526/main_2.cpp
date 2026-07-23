#include <iostream>
#include <limits>
#include <string>

using std::cout;
using std::string;

class Animal {
public:
    
    Animal() {
        cout << "Este es un animal\n";
    }
};

class Mammal : public virtual Animal {
public:
    Mammal() {
        cout << "Esto es un mamífero\n";
    } 
    
    virtual void born() {
        cout << "Naciendo de un vientre\n";
    }
};

class Oviparous : public virtual Animal {
public:
    Oviparous() {
        cout << "Esto es un ovíparo\n";
    }

    virtual void born() {
        cout << "Naciendo de un huevo\n";
    }
};

class Platypus : public virtual Mammal, public virtual Oviparous {
public:    
    using Oviparous::born;

    Platypus() {
        cout << "Esto es un ornitorrinco\n";
    }
};

int main() {
    Platypus p;
    p.born();
}