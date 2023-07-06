using System.ComponentModel.DataAnnotations;
namespace rh.Enums
{
    public enum EPermissoes
    {
        [Display(Name = "Funcionario")]
        Funcionario = 1,
        [Display(Name = "Gerente")]
        Gerente,
        [Display(Name = "Administrador")]
        Administrador
    }
}