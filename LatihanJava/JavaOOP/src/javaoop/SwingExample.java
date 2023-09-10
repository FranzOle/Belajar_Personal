/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import javax.swing.JFrame; 
import javax.swing.JLabel; 

public class SwingExample { 
    public static void main(String[] args) { 
        // create a new frame 
        JFrame frame = new JFrame("Swing Example"); 
  
        // create a label 
        JLabel label = new JLabel("Swing is awesome!"); 
  
        // add label to the frame 
        frame.add(label); 
  
        // set the size of the frame 
        frame.setSize(400, 400); 
  
        // set the default close operation 
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); 
  
        // make the frame visible 
        frame.setVisible(true); 
    } 
}
    
    