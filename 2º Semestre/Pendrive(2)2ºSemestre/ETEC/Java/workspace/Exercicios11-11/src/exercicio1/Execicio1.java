package exercicio1;

import java.awt.EventQueue;

import javax.swing.JFrame;
import net.miginfocom.swing.MigLayout;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Execicio1 {

	private JFrame frmExercicio;
	private JTextField nota1;
	private JTextField nota2;
	private JTextField nota3;
	private JTextField nota4;
	private JTextField media;
	private JButton btnCalcular;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Execicio1 window = new Execicio1();
					window.frmExercicio.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Execicio1() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmExercicio = new JFrame();
		frmExercicio.setTitle("Exercicio1");
		frmExercicio.setBounds(100, 100, 450, 300);
		frmExercicio.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmExercicio.getContentPane().setLayout(new MigLayout("", "[grow]", "[][][][][][][][]"));
		
		JLabel lblNota = new JLabel("Nota 1:");
		lblNota.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(lblNota, "flowx,cell 0 0,alignx center");
		
		nota1 = new JTextField();
		nota1.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(nota1, "cell 0 0");
		nota1.setColumns(10);
		
		JLabel lblNota_1 = new JLabel("Nota 2:");
		frmExercicio.getContentPane().add(lblNota_1, "flowx,cell 0 1,alignx center");
		
		nota2 = new JTextField();
		nota2.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(nota2, "cell 0 1,alignx center");
		nota2.setColumns(10);
		
		JLabel lblNota_2 = new JLabel("Nota 3:");
		frmExercicio.getContentPane().add(lblNota_2, "flowx,cell 0 2,alignx center");
		
		nota3 = new JTextField();
		nota3.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(nota3, "cell 0 2,alignx center");
		nota3.setColumns(10);
		
		JLabel lblNota_3 = new JLabel("Nota 4:");
		frmExercicio.getContentPane().add(lblNota_3, "flowx,cell 0 3,alignx center");
		
		nota4 = new JTextField();
		nota4.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(nota4, "cell 0 3,alignx center");
		nota4.setColumns(10);
		
		JLabel lblMedia = new JLabel("Media :");
		frmExercicio.getContentPane().add(lblMedia, "flowx,cell 0 5,alignx center");
		
		media = new JTextField();
		media.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(media, "cell 0 5,alignx center");
		media.setColumns(10);
		media.setEnabled(false);
		
		btnCalcular = new JButton("Calcular");
		btnCalcular.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				float n1 = Float.parseFloat(nota1.getText());
				float n2 = Float.parseFloat(nota2.getText());
				float n3 = Float.parseFloat(nota3.getText());
				float n4 = Float.parseFloat(nota4.getText());
				float resp = 0;
				
				resp =(n1+n2*2+n3*3+n4*4)/10;
				media.setText(resp + "");
			}
		});
		frmExercicio.getContentPane().add(btnCalcular, "cell 0 7,alignx center");
	}
	

	}

