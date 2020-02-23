using Flunt.Notifications;
using Flunt.Validations;

namespace RCSS.Domain.Entities.Base
{
    public abstract class EntidadeBase : Notifiable
    {
        private Contract _contrato;

        protected Contract Requires()
        {
            if (this._contrato == null)
                this._contrato = new Contract();

            return this._contrato;
        }

        private void AddContractNotifications()
        {
            if (this._contrato != null && this._contrato.Invalid)
                this.AddNotifications(this._contrato.Notifications);
        }

        public new bool Valid
        {
            get
            {
                this.AddContractNotifications();
                return base.Valid;
            }
        }

        public new bool Invalid
        {
            get
            {
                this.AddContractNotifications();
                return base.Invalid;
            }
        }

        public abstract bool Validar();
    }
}
