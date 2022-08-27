using Domain.Modles;
Employee st1=new Employee();
Employee st2=new Employee();
Employee st3=new Employee();
Employee st4=new Employee();
Employee st5=new Employee();


var depars = new List<Department>();
Department d1=new Department();
Department d2=new Department();
Department d3=new Department();
d1.Name="IT";
depars.Add(d1);
d2.Name="HR";
depars.Add(d2);
d3.Name="Accounting";
depars.Add(d3);


var roles = new List<Role>();
var r1=new Role();
var r2=new Role();
var r3=new Role();
var r4=new Role();
r1.Name="IT";
r2.Name="HR";
r3.Name="user";
r4.Name="accounting";
roles.Add(r1);
roles.Add(r2);
roles.Add(r3);
roles.Add(r4);


var expers = new List<Experience>();
var ex1 = new Experience();
var ex2 = new Experience();
var ex3 = new Experience();
var ex4 = new Experience();
var ex5 = new Experience();
ex1.Name = "Alif";
ex2.Name = "Mohir";
ex3.Name = "Eskhata";
ex4.Name = "Amonatbank";
ex5.Name = "SSB";



var emplos = new List<Employee>();
st1.FirstName = "Nurullo ";
st1.LastName = "Sulaymonov";
st1.Id = 1;
st1.Roles = new List<Role>(){r1,r2};
st1.Experiences = new List<Experience>(){ex1,ex2};
emplos.Add(st1);

st2.FirstName = "Ikromi ";
st2.LastName = "Imomiddin";
st2.Id = 2;
st2.Roles = new List<Role>(){r3,r4};
st2.Experiences = new List<Experience>(){ex1,ex4};
emplos.Add(st2);

st3.FirstName = "Shamsiddin ";
st3.LastName = "Khojakhonov";
st3.Id = 3;
st3.Roles = new List<Role>(){r1,r3};
st3.Experiences = new List<Experience>(){ex2,ex5};
emplos.Add(st3);

st4.FirstName = "Jahonzeb ";
st4.LastName = "Jahongirzoda";
st4.Id = 4;
st4.Roles = new List<Role>(){r1,r4};
st4.Experiences = new List<Experience>(){ex2,ex3};
emplos.Add(st4);

st5.FirstName = "Eshmatov ";
st5.LastName = "Toshmat";
st5.Id = 5;
st5.Roles = new List<Role>(){r4,r1};
st5.Experiences = new List<Experience>(){ex5,ex3};
emplos.Add(st5);


foreach (var item in emplos)
{
    item.GetInfo();
}