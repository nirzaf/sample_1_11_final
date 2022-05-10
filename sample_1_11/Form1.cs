using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sample_1_11 {
  public partial class Form1 : DevExpress.XtraEditors.XtraForm {
    public Form1() {
      InitializeComponent();

      var data = GetData();

      bindingSource1.DataSource = data;

/*      grid.DataSource = data;
      navigator.DataSource = data;
      nameEdit.DataBindings.Add("EditValue", data, "Name");
*/    }

    List<Person> GetData() {
      return new List<Person> {
        new Person{Name="Harry", Age = 23},
        new Person{Name="Susan", Age = 47},
        new Person{Name="Jim", Age = 43},
        new Person{Name="Anna", Age = 19},
        new Person{Name="Bill", Age = 35},
        new Person{Name="Mary", Age = 28},
        new Person{Name="Bob", Age = 46},
        new Person{Name="Linda", Age = 38},
        new Person{Name="Nick", Age = 38},
        new Person{Name="Karen", Age = 31},
        new Person{Name="Pete", Age = 42},
        new Person{Name="Liz", Age = 51}
      };
    }

  }

  public class Person : IEditableObject {
    public string Name { get; set; }
    public int Age { get; set; }

    string oldName;
    int oldAge;

    void IEditableObject.BeginEdit() {
      oldName = Name;
      oldAge = Age;
    }

    void IEditableObject.CancelEdit() {
      Name = oldName;
      Age = oldAge;
    }

    void IEditableObject.EndEdit() {
    }
  }
}
