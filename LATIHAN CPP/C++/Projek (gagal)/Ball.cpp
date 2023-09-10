#include "Ball.hpp"
 
//Ini adalah consturctor
Ball::Ball(float startX, float startY)
{
    position.x= startX;
    position.y= startY;
 
    ballShape.setRadius(5);
    ballShape.setPosition(position);
}
 
FloatRect Ball::getPosition()
{
    return ballShape.getGlobalBounds();
}
 
CircleShape Ball::getShape()
{
    return ballShape;
}
 
float Ball::getXVelocity()
{
    return xVelocity;
}
 
void Ball::reboundSides()
{
    xVelocity = -xVelocity;
}
 
void Ball::reboundBatOrtop()
{
    position.y -= (yVelocity * 30);
    yVelocity = -yVelocity;
}
 
void Ball::hitBottom()
{
    position.y = 1;
    position.x = 500;
}
 
void Ball::update()
{
    // Update posisi bola
    position.y += yVelocity;
    position.x += xVelocity;
    ballShape.setPosition(position);
}

