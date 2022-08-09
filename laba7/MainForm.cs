using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba7
	/*	Класс, содержит следующие члены.
			a. Поля для хранения координат х и у.
			b. Два метода, один из которых возвращает х, второй – у ;
			c. Конструктор класса с двумя параметрами.
		Двухсвязный не кольцевой список. На форме должны быть кнопки,
		выполняющие следующие действия:
			a. Перемещать текущую позицию на элемент с большим номером, если
				это возможно
			b. Перемещать текущую позицию на элемент с меньшим номером, если
				это возможно.
			c. Удалять текущий элемент.
			d. Вставлять новый элемент, следом за текущим элементом, при этом
				новый элемент становится текущим
	 */
{
	public partial class MainForm : Form
	{
		Graphics ga;
		Spisok MoySpisok=new Spisok();
		public MainForm()
		{
			InitializeComponent();
			ga=Graphics.FromHwnd(this.panel1.Handle);
			MoySpisok.setGraphics(ga);
		}
	void Button1Click(object sender, EventArgs e)
		{
		MoySpisok.Del();
		label1.Text=Convert.ToString(MoySpisok.Count);
		}
	void Button2Click(object sender, EventArgs e)
		{
		MoySpisok.NextPos();
		}
	void Button4Click(object sender, EventArgs e) 
		{
	try {
		MoySpisok.Add(new Vector ((Convert.ToInt32(textBox1.Text)), Convert.ToInt32(textBox2.Text)));
		label1.Text=Convert.ToString(MoySpisok.Count);}
		catch (FormatException)
		{
		MessageBox.Show("Ошибка ввода (введите чила)");
		}
		}
	void Button3Click(object sender, EventArgs e) 
		{
		MoySpisok.Draw();
		MoySpisok.LeftPos();
		}
	void MainFormLoad(object sender, EventArgs e)
		{	
		}
		
	}
}