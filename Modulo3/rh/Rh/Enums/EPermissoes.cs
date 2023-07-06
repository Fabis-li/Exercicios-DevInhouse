using System.ComponentModel.DataAnnotations;

namespace Rh.Enums
{
    public enum EPermissoes
    {
        [Display(Name = "Administrador")]
        Administrador = 1,
        [Display(Name = "Gerente")]
        Gerente,
        [Display(Name = "Funcionario")]
        Funcionario

    }
}
