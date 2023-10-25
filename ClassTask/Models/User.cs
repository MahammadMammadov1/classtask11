using ClassTask.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class User
    {
		private static int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _name;
        public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				int count = 0;
				for (int i = 0; i < value.Length; i++)
				{
					if (char.IsDigit(value[i])) count++;
				}


				if(value == null || count ==0)
				{
					_name = value;
				}

				else
				{
					throw new InvalidNameException(" bosh ve reqem gondermek olmaz");
				}
			} 
		}
		private string _surName;
		public string SurName
		{
			get
			{
				return _surName;
			}
			set
			{
                int count = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i])) count++;
                }


                if (value == null || count == 0)
                {
                    _name = value;
                }

                else
                {
                    throw new InvalidSurNameException(" bosh ve reqem gondermek olmaz");
                }
            }
		}
		public string _userName;
        public string UserName
		{
			get
			{
				return _userName;
			}

			set
			{
				value = string.Concat(Name.ToLower() + "." + SurName.ToLower());
				_userName = value;
			}
		}

		private string _password;

		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				int count = 0;
				for (int i = 0; i < value.Length; i++)
				{
					if (char.IsDigit(value[i])) count++;
				}



				if (value.Length >= 8 && char.IsUpper(value[0]) && count >= 1)
				{
					_password = value;
				}
				else
				{
					throw new InvalidPasswordException("min 8 uzunluqlu ola biler, boyuk herfle baslamalidir, icerisinde minimum 1 reqem olmalidir");
				}
			}
		}



		static User()
		{
			_id = 0;
		}

		public User( )
		{
			_id++;
			Id = _id;
			
		}
	}
}
