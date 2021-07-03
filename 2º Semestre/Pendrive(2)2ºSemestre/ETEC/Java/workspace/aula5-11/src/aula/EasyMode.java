package aula;

import java.awt.EventQueue;

import javax.swing.JFrame;
import java.awt.FlowLayout;
import javax.swing.JLabel;
import javax.swing.JTextField;
import java.awt.GridLayout;
import javax.swing.BoxLayout;
import java.awt.GridBagLayout;
import java.awt.GridBagConstraints;
import java.awt.Insets;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import net.miginfocom.swing.MigLayout;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class EasyMode {

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					EasyMode window = new EasyMode();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public EasyMode() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(new MigLayout("", "[31px][246px][grow]", "[20px][][][][][]"));
		
		JLabel lblNome = new JLabel("Nome:");
		frame.getContentPane().add(lblNome, "cell 1 0,alignx right,aligny center");
		
		textField = new JTextField();
		textField.setColumns(30);
		frame.getContentPane().add(textField, "cell 2 0,alignx center,aligny top");
		
		JLabel lblNota = new JLabel("Nota1:");
		frame.getContentPane().add(lblNota, "cell 1 1,alignx trailing");
		
		textField_1 = new JTextField();
		frame.getContentPane().add(textField_1, "cell 2 1,growx");
		textField_1.setColumns(10);
		
		JLabel lblNota_1 = new JLabel("Nota2:");
		frame.getContentPane().add(lblNota_1, "cell 1 2,alignx trailing");
		
		textField_2 = new JTextField();
		frame.getContentPane().add(textField_2, "cell 2 2,growx");
		textField_2.setColumns(10);
		
		JLabel lblMedia = new JLabel("Media:");
		frame.getContentPane().add(lblMedia, "cell 1 3,alignx trailing");
		
		textField_3 = new JTextField();
		frame.getContentPane().add(textField_3, "cell 2 3,growx");
		textField_3.setColumns(10);
		
		JButton btnNewButton = new JButton("Pesquisar");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
			}
		});
		frame.getContentPane().add(btnNewButton, "flowx,cell 1 5,alignx right");
		
		JButton btnSalvar = new JButton("Salvar");
		frame.getContentPane().add(btnSalvar, "cell 1 5");
		
		JButton btnCalcular = new JButton("Calcular");
		frame.getContentPane().add(btnCalcular, "flowx,cell 2 5");
		
		JButton btnSair = new JButton("Sair");
		frame.getContentPane().add(btnSair, "cell 2 5");
	}

}
