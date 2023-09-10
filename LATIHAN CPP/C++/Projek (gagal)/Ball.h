#ifndef Ball_hpp
#define Ball_hpp
 
#include
#include 
 
using namespace sf;
class Ball
{
private:
    Vector2f position;
    CircleShape ballShape;
 
    float xVelocity= .4f;
    float yVelocity= .4f;
 
public:
    Ball(float startX, float startY);
    FloatRect getPosition();
    CircleShape getShape();
    float getXVelocity();
    void reboundSides();
    void reboundBatOrtop();
    void hitBottom();
    void update();
 
};
 
#endif /* Ball_hpp */
