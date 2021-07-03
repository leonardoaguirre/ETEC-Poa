package calculadora;


import javax.swing.*;
import java.awt.*;

public class Menu extends JFrame
{
    
	public void init() {

		JMenuBar M1 = new JMenuBar();

		 JMenu menuArquivo = new JMenu("Arquivo");
		 Container menuSave = new JMenu("Salvar");

		JMenuItem miNovo = new JMenuItem("Novo");
		JMenuItem miAbrir = new JMenuItem("Abrir");
		JMenuItem miSalvar = new JMenuItem("Salvar");
		JMenuItem miSalvarC = new JMenuItem("Salvar Como");
		JMenuItem miSalvarT = new JMenuItem("Salvar Tudo");
		JMenuItem miSair = new JMenuItem("Sair");

		menuSave.add(miSalvar);
		menuSave.add(miSalvarC);
		menuSave.add(miSalvarT);

		menuArquivo.add(miNovo);
		menuArquivo.add(miAbrir);
		menuArquivo.add(menuSave);
		menuArquivo.addSeparator();
		menuArquivo.add(miSair);

		M1.add(menuArquivo);
		setJMenuBar(M1);
		setSize(250, 150);
		setVisible(true);
	}
	public static void main(String args[]) {
		Menu a = new Menu();
		a.init();
	}
}
