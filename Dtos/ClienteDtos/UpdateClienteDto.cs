using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Teste.Dtos.ClienteDtos
{
    public class UpdateClienteDto : Notifiable<Notification>, IDtoBase
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<UpdateClienteDto>()
                    .Requires()
                    .IsNotEmpty(Nome, "Cliente.Nome", "Nome não pode ser vazio")
            );
        }
    }
}