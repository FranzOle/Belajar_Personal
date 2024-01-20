import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class PlanesGame extends JFrame {
    private int planeY = 200;
    private int planeSpeed = 5;
    private List<Obstacle> obstacles = new ArrayList<>();
    private int obstacleSpeed = 3;
    private int score = 0;

    private class Obstacle {
        int x;
        int y;
        int width;
        int height;

        Obstacle(int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }

    public PlanesGame() {
        setTitle("Dynamic Planes Game");
        setSize(800, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setResizable(false);
        setLocationRelativeTo(null);

        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                int key = e.getKeyCode();
                if (key == KeyEvent.VK_UP) {
                    planeY -= planeSpeed;
                } else if (key == KeyEvent.VK_DOWN) {
                    planeY += planeSpeed;
                }
            }
        });

        Timer timer = new Timer(20, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                moveObstacles();
                repaint();
                checkCollision();
                updateScore();
            }
        });
        timer.start();
        generateInitialObstacles();
    }

    private void moveObstacles() {
        for (Obstacle obstacle : obstacles) {
            obstacle.x -= obstacleSpeed;
        }
        obstacles.removeIf(obstacle -> obstacle.x + obstacle.width < 0);
    }

    private void generateInitialObstacles() {
        Random random = new Random();
        for (int i = 0; i < 5; i++) {
            int width = random.nextInt(50) + 30;
            int height = random.nextInt(100) + 30;
            obstacles.add(new Obstacle(800 + i * 300, random.nextInt(300), width, height));
        }
    }

    private void checkCollision() {
        Rectangle planeRect = new Rectangle(100, planeY, 50, 30);
        for (Obstacle obstacle : obstacles) {
            Rectangle obstacleRect = new Rectangle(obstacle.x, obstacle.y, obstacle.width, obstacle.height);
            if (planeRect.intersects(obstacleRect)) {
                JOptionPane.showMessageDialog(this, "Game Over! Your Score: " + score);
                System.exit(0);
            }
        }
    }

    private void updateScore() {
        score++;
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);

        g.setColor(Color.BLUE);
        g.fillRect(100, planeY, 50, 30);

        for (Obstacle obstacle : obstacles) {
            g.setColor(Color.RED);
            g.fillRect(obstacle.x, obstacle.y, obstacle.width, obstacle.height);
        }

        g.setColor(Color.BLACK);
        g.setFont(new Font("Arial", Font.PLAIN, 18));
        g.drawString("Score: " + score, 10, 25);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            PlanesGame game = new PlanesGame();
            game.setVisible(true);
        });
    }
}
