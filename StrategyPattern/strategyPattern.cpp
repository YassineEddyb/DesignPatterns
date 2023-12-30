/*
    The Strategy Pattern defines a family of algorithms,
    encapsulates each one, and makes them interchangeable.
    Strategy lets the algorithm vary independently from
    clients that use it.
*/

#include "Duck.cpp"

class RubberDuck : public Duck
{
public:
    RubberDuck()
    {
        flyBehavior = new NoFly();
        quackBehavior = new NoQauck();
    }
    void display()
    {
        std::cout << "I'm a rubber duck!" << std::endl;
    }
};

class MallardDuck : public Duck
{
public:
    MallardDuck()
    {
        flyBehavior = new Fly();
        quackBehavior = new Qauck();
    }
    void display()
    {
        std::cout << "I'm a mallar duck!" << std::endl;
    }
};

int main()
{
    Duck *d1 = new RubberDuck();
    Duck *d2 = new MallardDuck();

    d1->display();
    d1->preformFly();
    d1->preformQuarck();
    d1->setDuckFlyBehavior(new Fly());
    d1->setDuckQauckBehavior(new Qauck());
    d1->preformFly();
    d1->preformQuarck();

    d2->display();
    d2->preformFly();
    d2->preformQuarck();
}
