#include "behaviors.cpp"

class Duck
{
public:
    IFlyBehavior *flyBehavior;
    IQuackBehavior *quackBehavior;

    void eat()
    {
        std::cout << "eat" << std::endl;
    }
    virtual void display() = 0;

    void preformFly()
    {
        flyBehavior->fly();
    }
    void preformQuarck()
    {
        quackBehavior->quack();
    }

    void setDuckFlyBehavior(IFlyBehavior *fly)
    {
        flyBehavior = fly;
    }

    void setDuckQauckBehavior(IQuackBehavior *quack)
    {
        quackBehavior = quack;
    }
};
