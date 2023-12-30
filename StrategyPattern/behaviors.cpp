#include <iostream>

class IFlyBehavior
{
public:
    virtual void fly() = 0;
};

class Fly : public IFlyBehavior
{
public:
    void fly()
    {
        std::cout << "fly" << std::endl;
    }
};

class NoFly : public IFlyBehavior
{
public:
    void fly()
    {
        std::cout << "no fly" << std::endl;
    }
};

class IQuackBehavior
{
public:
    virtual void quack() = 0;
};

class Qauck : public IQuackBehavior
{
public:
    void quack()
    {
        std::cout << "quack" << std::endl;
    }
};

class NoQauck : public IQuackBehavior
{
public:
    void quack()
    {
        std::cout << "no quack" << std::endl;
    }
};