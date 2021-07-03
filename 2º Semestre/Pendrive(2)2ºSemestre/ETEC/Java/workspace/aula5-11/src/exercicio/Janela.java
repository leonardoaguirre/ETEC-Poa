package exercicio;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JToolBar;
import java.awt.BorderLayout;
import javax.swing.JMenuBar;
import javax.swing.JLabel;
import java.awt.FlowLayout;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import java.awt.GridLayout;
import com.jgoodies.forms.layout.FormLayout;
import com.jgoodies.forms.layout.ColumnSpec;
import com.jgoodies.forms.layout.RowSpec;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import net.miginfocom.swing.MigLayout;
import javax.swing.JComboBox;
import javax.swing.JButton;
import javax.swing.JMenuItem;
import javax.swing.JCheckBoxMenuItem;
import javax.swing.JMenu;
import javax.swing.JTextArea;
import java.awt.ComponentOrientation;
import java.awt.Window.Type;

public class Janela {

	private JFrame frmFormulario;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;
	private JTextField textField_6;
	private JTextField textField_7;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Janela window = new Janela();
					window.frmFormulario.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Janela() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmFormulario = new JFrame();
		frmFormulario.setTitle("Formulario");
		frmFormulario.setBounds(100, 100, 427, 363);
		frmFormulario.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JLabel lblNewLabel = new JLabel("C\u00F3digo:");
		lblNewLabel.setHorizontalAlignment(SwingConstants.RIGHT);
		
		textField = new JTextField();
		textField.setColumns(10);
		frmFormulario.getContentPane().setLayout(new MigLayout("", "[67px][161px,grow][4px][27px][4px][161px]", "[20px][20px][20px][20px][22px][20px][72px,grow][23px][23px]"));
		frmFormulario.getContentPane().add(lblNewLabel, "cell 0 0,alignx right,aligny center");
		frmFormulario.getContentPane().add(textField, "cell 1 0,growx,aligny top");
		
		JLabel lblNome = new JLabel("Nome:");
		frmFormulario.getContentPane().add(lblNome, "cell 0 1,alignx right,aligny center");
		
		textField_1 = new JTextField();
		frmFormulario.getContentPane().add(textField_1, "cell 1 1 5 1,growx,aligny top");
		textField_1.setColumns(10);
		
		JLabel lblRg = new JLabel("Rg:");
		frmFormulario.getContentPane().add(lblRg, "cell 0 2,alignx right,aligny center");
		
		textField_2 = new JTextField();
		frmFormulario.getContentPane().add(textField_2, "cell 1 2,growx,aligny top");
		textField_2.setColumns(10);
		
		JLabel lblNewLabel_1 = new JLabel("CPF:");
		lblNewLabel_1.setHorizontalAlignment(SwingConstants.LEFT);
		frmFormulario.getContentPane().add(lblNewLabel_1, "cell 3 2,alignx right,aligny center");
		
		textField_3 = new JTextField();
		frmFormulario.getContentPane().add(textField_3, "cell 5 2,growx,aligny top");
		textField_3.setColumns(10);
		
		JLabel lblEndereo = new JLabel("Endere\u00E7o:");
		frmFormulario.getContentPane().add(lblEndereo, "cell 0 3,alignx right,aligny center");
		
		textField_4 = new JTextField();
		frmFormulario.getContentPane().add(textField_4, "cell 1 3 5 1,growx,aligny top");
		textField_4.setColumns(10);
		
		JLabel lblCidade = new JLabel("Cidade:");
		frmFormulario.getContentPane().add(lblCidade, "cell 0 4,alignx right,aligny center");
		
		textField_5 = new JTextField();
		frmFormulario.getContentPane().add(textField_5, "cell 1 4,growx,aligny center");
		textField_5.setColumns(10);
		
		JLabel lblUf = new JLabel("UF:");
		frmFormulario.getContentPane().add(lblUf, "cell 3 4,alignx right,aligny center");
		
		JComboBox comboBox = new JComboBox();
		frmFormulario.getContentPane().add(comboBox, "cell 5 4,growx,aligny top");
		
		JLabel lblEstadoCivil = new JLabel("Estado Civil:");
		frmFormulario.getContentPane().add(lblEstadoCivil, "cell 0 5,alignx right,aligny center");
		
		textField_6 = new JTextField();
		frmFormulario.getContentPane().add(textField_6, "cell 1 5,growx,aligny top");
		textField_6.setColumns(10);
		
		JLabel lblNasc = new JLabel("Nasc:");
		frmFormulario.getContentPane().add(lblNasc, "cell 3 5,alignx left,aligny center");
		
		textField_7 = new JTextField();
		frmFormulario.getContentPane().add(textField_7, "cell 5 5,growx,aligny top");
		textField_7.setColumns(10);
		
		JLabel lblObservaes = new JLabel("Observa\u00E7\u00F5es:");
		frmFormulario.getContentPane().add(lblObservaes, "cell 0 6,alignx left,aligny top");
		
		JTextArea textArea = new JTextArea();
		frmFormulario.getContentPane().add(textArea, "cell 1 6 5 1,grow");
		
		JButton btnSalvar = new JButton("Salvar");
		frmFormulario.getContentPane().add(btnSalvar, "cell 1 7,growx,aligny center");
		
		JButton btnConsultar = new JButton("Consultar");
		frmFormulario.getContentPane().add(btnConsultar, "cell 5 7,growx,aligny top");
		
		JButton btnApagar = new JButton("Apagar");
		frmFormulario.getContentPane().add(btnApagar, "cell 1 8,growx,aligny top");
		
		JButton btnSair = new JButton("Sair");
		frmFormulario.getContentPane().add(btnSair, "cell 5 8,growx,aligny top");
		
		JMenuBar menuBar = new JMenuBar();
		frmFormulario.setJMenuBar(menuBar);
		
		JMenu mnNewMenu = new JMenu("Arquivo");
		menuBar.add(mnNewMenu);
		
		JMenuItem mntmAbrir = new JMenuItem("Abrir");
		mnNewMenu.add(mntmAbrir);
		
		JMenuItem mntmSalvar = new JMenuItem("Salvar");
		mnNewMenu.add(mntmSalvar);
		
		JMenuItem mntmSalvarComo = new JMenuItem("Salvar como");
		mnNewMenu.add(mntmSalvarComo);
		
		JMenuItem mntmAjuda = new JMenuItem("Ajuda");
		menuBar.add(mntmAjuda);
	}

}
