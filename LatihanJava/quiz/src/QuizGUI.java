import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import quiz.Question;

public class QuizGUI {
    private final JFrame frame;
    private final JPanel panel;
    private final JLabel questionLabel;
    private final JRadioButton[] optionButtons;
    private final JButton submitButton;

    private Question[] questions;
    private int currentQuestionIndex;
    private int score;

    public QuizGUI(Question[] questions) {
        this.questions = questions;
        this.currentQuestionIndex = 0;
        this.score = 0;

        frame = new JFrame("Quiz pengetahuan umum");
        panel = new JPanel();
        panel.setLayout(new BoxLayout(panel, BoxLayout.Y_AXIS));
        questionLabel = new JLabel();
        optionButtons = new JRadioButton[4];

        for (int i = 0; i < 4; i++) {
            optionButtons[i] = new JRadioButton();
        }

        submitButton = new JButton("Submit");
        submitButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                checkAnswer();
            }
        });

        setupGUI();
        showNextQuestion();
    }

    private void setupGUI() {
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 300);
        frame.getContentPane().add(panel);

        panel.add(questionLabel);

        ButtonGroup group = new ButtonGroup();
        for (int i = 0; i < 4; i++) {
            group.add(optionButtons[i]);
            panel.add(optionButtons[i]);
        }

        panel.add(submitButton);
    }

    private void showNextQuestion() {
        if (currentQuestionIndex < questions.length) {
            Question currentQuestion = questions[currentQuestionIndex];
            questionLabel.setText(currentQuestion.getQuestionText());

            String[] options = currentQuestion.getOptions();
            for (int i = 0; i < 4; i++) {
                optionButtons[i].setText(options[i]);
                optionButtons[i].setSelected(false);
            }

            currentQuestionIndex++;
        } else {
            showResult();
        }
    }

    private void checkAnswer() {
        Question currentQuestion = questions[currentQuestionIndex - 1];
        int selectedOption = -1;
        for (int i = 0; i < 4; i++) {
            if (optionButtons[i].isSelected()) {
                selectedOption = i;
                break;
            }
        }

        if (selectedOption == currentQuestion.getCorrectAnswerIndex()) {
            score++;
        }

        showNextQuestion();
    }

    private void showResult() {
        frame.getContentPane().removeAll();
        float nilai = score/questions.length * 100;
        JLabel resultLabel = new JLabel("Quiz completed! Your jawaban yang benar: " + score + " dari " + questions.length);
        resultLabel.setHorizontalAlignment(JLabel.CENTER);
        frame.getContentPane().add(resultLabel);
//        frame.getContentPane().add(scoreLabel);
        frame.revalidate();
    }

    public void start() {
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        
        Question[] questions = {
            new Question("2 * (2 + 3) adalah ", new String[]{"7", "5", "10", "2"}, 2),
            new Question("Ibu kota Prancis adalah", new String[]{"Berlin", "Paris", "Madrid", "Rome"}, 1),
            new Question("Planet apa yang disebut planet merah", new String[]{"Mars", "Jupiter", "Venus", "Saturnus"}, 0),
        };

        QuizGUI quiz = new QuizGUI(questions);
        quiz.start();
    }
}
