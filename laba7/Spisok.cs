using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace laba7
{
public class Spisok {		//Описание класса «Список элементов»
	private List<Vector> List=new List<Vector>();
	private int p=-1;
	Graphics g=null;
public void Add(Vector v){	//Добавление элемента
	List.Insert(++p,v);
	this.Draw();
	}
public void Del(){
	if(Count<1)return;
	List.RemoveAt(p);
	if(p>0)p--;
	if(Count<1)p=-1;
	Draw();
	}
public void Clear(){		//Очистка списка
	List.Clear();
	p=-1;
	this.Draw();
	}
public int Count{			//Количество элементов
	get{return List.Count;}
	}
public void NextPos(){ 		//Перемещение текущей позиции на элемент с большим номером
	if(p<Count-1)
	{
	++p;
	this.Draw();}
	else{
	p=0;
this.Draw();
}
		if (Count==0) MessageBox.Show ("Нет элементов");
}
	public int petyka()			//Количество элементов
			{
			return p;
			}

	public void LeftPos() 		//Перемещение текущей позиции на элемент с меньшим номером
			{
	if(p>0)
		{
		p=p-1;
		this.Draw();
		}
	else
			{
			p=Count-1;
			this.Draw();
			}
	if (Count==0) MessageBox.Show ("Нет элементов");
}

public void ClearPos(){		//Перемещение текущей позиции первый элемент
	if(this.Count==0)return;
		p=0;this.Draw();
					}

public void setGraphics(Graphics gg){
	g=gg;
}

public void Draw()			//Описание метода Draw класса «Список элементов»
{
	if(g==null)return;
	g.Clear(Color.White);
		if(Count<1)return;
			g.FillEllipse(new SolidBrush(Color.GreenYellow), ((Vector)List[p]).getX(),((Vector)List[p]).getY(),20,20);
			Pen pen=new Pen(Color.Red);
	for(int i=0;i<Count;i++)
	{
		g.DrawString(i.ToString(),new Font("New Times Roman",8),new SolidBrush(Color.Blue), ((Vector)List[i]).getX()+1,((Vector)List[i]).getY()+3);
		g.DrawEllipse(pen, ((Vector)List[i]).getX(),((Vector)List[i]).getY(),20,20);
	}
		}
	}
}