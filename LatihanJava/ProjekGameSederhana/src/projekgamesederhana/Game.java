package projekgamesederhana;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Game extends JPanel implements ActionListener {
    private Player player;
    private Obstacle obstacle;

    private Timer timer;
    private int score;

    public Game() {
        player = new Player();
        obstacle = new Obstacle();

        timer = new Timer(10, this);
        score = 0;

        setPreferredSize(new Dimension(800, 400));
        setBackground(Color.WHITE);
        setFocusable(true);
        addKeyListener(new GameKeyListener(this));

        timer.start();
    }

    public void actionPerformed(ActionEvent e) {
        player.move();
        obstacle.move();

        if (player.intersects(obstacle)) {
            timer.stop();
            JOptionPane.showMessageDialog(this, "Game Over! Score: " + score);
            System.exit(0);
        }

        repaint();
    }

    public void increaseScore() {
        score++;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);

        player.draw(g);
        obstacle.draw(g);

        g.setColor(Color.BLACK);
        g.setFont(new Font("Arial", Font.PLAIN, 20));
        g.drawString("Score: " + score, 20, 30);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Dino Chrome");
        Game game = new Game();
        frame.add(game);
        frame.pack();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}

