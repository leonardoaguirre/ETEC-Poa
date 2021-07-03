package exercicio2;

import java.awt.EventQueue;

import javax.swing.JFrame;
import net.miginfocom.swing.MigLayout;
import javax.swing.JTextPane;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.SwingConstants;

public class Exercicio2 {

	private JFrame frmExercicio;
	private JTextField result;
	private JTextField numeroPensado;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Exercicio2 window = new Exercicio2();
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
	public Exercicio2() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmExercicio = new JFrame();
		frmExercicio.setTitle("Exercicio2");
		frmExercicio.setBounds(100, 100, 450, 300);
		frmExercicio.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmExercicio.getContentPane().setLayout(new MigLayout("", "[564px]", "[14px][][][][][]"));
		
		JLabel lblPenseUmNmero = new JLabel("Pense um n\u00FAmero , multiplique por 2 , some 6 ao \r\nresultado, divida o resultado por 2,");
		frmExercicio.getContentPane().add(lblPenseUmNmero, "cell 0 0,alignx left,aligny top");
		
		JLabel lblQuantoDeuInforme = new JLabel("quanto deu? informe o resultado:");
		frmExercicio.getContentPane().add(lblQuantoDeuInforme, "flowx,cell 0 1,alignx center");
		
		result = new JTextField();
		result.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(result, "cell 0 1,alignx center");
		result.setColumns(10);
		
		JLabel lblONumeroPensado = new JLabel("O numero pensado foi:");
		frmExercicio.getContentPane().add(lblONumeroPensado, "flowx,cell 0 3,alignx center");
		
		numeroPensado = new JTextField();
		numeroPensado.setHorizontalAlignment(SwingConstants.CENTER);
		frmExercicio.getContentPane().add(numeroPensado, "cell 0 3,alignx center");
		numeroPensado.setColumns(10);
		numeroPensado.setEnabled(false);
		
		JButton btnCalcularNumeroPensado = new JButton("Calcular Numero Pensado");
		btnCalcularNumeroPensado.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int resultado = (int) Float.parseFloat(result.getText());
				int resultFinal;
				
				resultFinal = resultado - 3;
				numeroPensado.setText(resultFinal+"");
			
			}
		});
		frmExercicio.getContentPane().add(btnCalcularNumeroPensado, "cell 0 5,alignx center");
	}

}
