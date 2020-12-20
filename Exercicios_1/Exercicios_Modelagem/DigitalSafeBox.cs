using System;

namespace Exercicios_Modelagem
{
    public class DigitalSafeBox : HouseholdObjects
    {
        private string safePassword { set; get; }
        private DateTime lastPasswordUpdate { set; get; }
        private bool safeLocked { set; get; }
        private bool safeBlocked { set; get; }
        public int passwordRejection { private set; get; }

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

        private void setSafeBlocked()
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

        public bool toUnlockSafeBox( string safePassword, string passwordConfirmation )
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
                            Console.WriteLine("Senha correta!\nCofre aberto!\n"); return true;
                        }
                        else
                        {
                            Console.WriteLine(toUpdateRejection(true) ? "Senha recusada!\nVocê usou " + passwordRejection + " de 3 tentativas antes de bloquear o cofre...\n" : "Senha recusada!\nCofre bloqueado!\n");
                            return false;
                        }
                    }
                    else Console.WriteLine("Cofre bloqueado!\n"); return false;
                }
                else Console.WriteLine("Senhas incompatíveis!\n"); return false;
            }
            else Console.WriteLine("O cofre já está aberto!\n"); return false;

        }

        public void toLockSafeBox()
        {
            safeLocked = true;
            Console.WriteLine("Cofre fechado!\n");
        }

        public bool toUpdatePassword( string newPassword )
        {
            if(!safeLocked && !safeBlocked)
            {
                safePassword = newPassword;
                lastPasswordUpdate = DateTime.Now;
                Console.WriteLine("Senhas alterada com sucesso!\n");
                return true;
            }
            else Console.WriteLine("Abra o cofre para alterar a senha!\n");
            return false;
        }

        public override void showDescription()
        {
            Console.WriteLine("\nTipo: Cofre Digital");
            base.showDescription();
            Console.WriteLine("Última alteração de senha: {0 : dd/MM/yyyy HH:mm:ss}\nO cofre está bloqueado? {1}\n", lastPasswordUpdate, safeBlocked);
        }
    }
}
