package projekgamesederhana;

import java.awt.*;

public class Player {
    private int x;
    private int y;
    private int velocityY;
    private Rectangle boundingBox;

    public Player() {
        x = 100;
        y = 300;
        velocityY = 0;
        boundingBox = new Rectangle(x, y, 20, 40);
    }

    public void move() {
        y += velocityY;
        boundingBox.setLocation(x, y);
        if (y >= 300) {
            y = 300;
            velocityY = 0;
        }
    }

    public void jump() {
        if (y == 300) {
            velocityY = -10;
        }
    }

    public boolean intersects(Obstacle obstacle) {
        return boundingBox.intersects(obstacle.getBounds());
    }

    public void draw(Graphics g) {
        g.setColor(Color.BLACK);
        g.fillRect(x, y, 20, 40);
    }
}
