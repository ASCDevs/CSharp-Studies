using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Auth.Application.Members.Login
{
    public record LoginCommand(string email) : ICommand<string>;
}
