package projekgamesederhana;

import java.awt.*;

public class Obstacle {
    private int x;
    private int y;
    private int velocityX;
    private Rectangle boundingBox;

    public Obstacle() {
        x = 800;
        y = 300;
        velocityX = -5;
        boundingBox = new Rectangle(x, y, 20, 40);
    }

    public void move() {
        x += velocityX;
        boundingBox.setLocation(x, y);
        if (x < -20) {
            x = 800;
        }
    }

    public Rectangle getBounds() {
        return boundingBox;
    }

    public void draw(Graphics g) {
        g.setColor(Color.RED);
        g.fillRect(x, y, 20, 40);
    }
}
