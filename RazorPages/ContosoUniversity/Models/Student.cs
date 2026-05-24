using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }

		[Required(ErrorMessage = "Фаимилия - это обязательное поле")]
		[StringLength(50,ErrorMessage = "Превышено максимальное колиество символов")]
		[RegularExpression(@"^[A-ZА-Я]+[a-z а-я]*$", ErrorMessage = "Фамилия может включать в себя только символы Русского и Латинского алфавита, а так же должна быть написана с большой буквы")]
		[Display(Name = "Фамилия")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Имя является обязательным")]
		[StringLength(50, ErrorMessage = "Превышено максимальное количество симолов")]
		[RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage = "Имя может включать в себя только символы Русского и Латинского алфавита, а так же должно быть написана с большой буквы")]
		[Display(Name = "Имя")]
		public string FirstName { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Дата поступления")]
		public DateTime EnrollmentDate { get; set; }

		//Calculated properties:
		[Display(Name = "Студент")]
		public string FullName
		{
			get => $"{LastName} {FirstName}";
		}

		//Navigation properties:
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
