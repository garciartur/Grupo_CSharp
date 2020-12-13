using System;

namespace Exercicios_Modelagem
{
    class DigitalSafeBox : HouseholdObjects
    {
        private string safePassword { set; get; }
        private DateTime lastPasswordUpdate { set; get; }
        private bool safeLocked { set; get; }
        private bool safeBlocked { set; get; }
        private int passwordRejection { set; get; }

        public DigitalSafeBox( string safePassword )
        {
            this.safePassword = safePassword;
            safeLocked = false;
            safeBlocked = false;
            passwordRejection = 0;
            lastPasswordUpdate = DateTime.Now;
        }

        public bool toConfirmPassword(string safePassword, string passwordConfirmation)
        {
            return passwordConfirmation == safePassword ? true : false;
        }

        public bool toValidatePassword(string safePassword)
        {
            if (getSafeBlocked()) return false;
            else return safePassword == this.safePassword ? true : false;
        }

        public bool getSafeBlocked()
        {
            return safeBlocked;
        }

        public void setSafeBlocked()
        {
            safeBlocked = true;
        }

        public bool toUpdateRejection(bool newRejection)
        {
            if (newRejection)
            {
                if (passwordRejection < 3)
                {
                    passwordRejection++;
                    return true;
                }
                else
                {
                    setSafeBlocked();
                    return false;
                }
            }
            else
            {
                passwordRejection = 0;
                return false;
            }
        }

        public void toUnlockSafeBox( string safePassword, string passwordConfirmation )
        {
            if( safeLocked )
            {
                if (toConfirmPassword(safePassword, passwordConfirmation))
                {
                    if (!safeBlocked)
                    {
                        if (toValidatePassword(safePassword))
                        {
                            safeLocked = false;
                            toUpdateRejection(false);
                            Console.WriteLine("Senha correta!\nCofre aberto!\n");
                        }
                        else
                        {
                            Console.WriteLine(toUpdateRejection(true) ? "Senha recusada!\nVocê usou " + passwordRejection + " de 3 tentativas antes de bloquear o cofre...\n" : "Senha recusada!\nCofre bloqueado!\n");
                        }
                    }
                    else Console.WriteLine("Cofre bloqueado!\n");

                }
                else Console.WriteLine("Senhas incompatíveis!\n");
            }
            else Console.WriteLine("O cofre já está aberto!\n");
        }

        public void toLockSafeBox()
        {
            safeLocked = true;
            Console.WriteLine("Cofre fechado!\n");
        }

        public void toUpdatePassword( string newPassword )
        {
            if(!safeLocked && !safeBlocked)
            {
                safePassword = newPassword;
                lastPasswordUpdate = DateTime.Now;
                Console.WriteLine("Senhas alterada com sucesso!\n");
            }
            else Console.WriteLine("Abra o cofre para alterar a senha!\n");
        }

        public override void showDescription()
        {
            Console.WriteLine("\nTipo: Cofre Digital");
            base.showDescription();
            Console.WriteLine("Última alteração de senha: {0 : dd/MM/yyyy HH:mm:ss}\nO cofre está bloqueado? {1}\n", lastPasswordUpdate, safeBlocked);
        }
    }
}
