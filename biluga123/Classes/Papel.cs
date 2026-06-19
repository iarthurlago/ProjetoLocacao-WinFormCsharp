using System;
using System.Collections.Generic;
using System.Text;

namespace Locacao.Classes
{
    // Os três papéis do sistema RBAC.
    // Usamos enum porque os papéis são fixos e conhecidos em tempo de compilação.
    // Cada papel carrega implicitamente o que pode fazer (definido nos Services e Forms).
    public enum Papel
    {
        Visualizador = 1,  // só lê dados
        Operador = 2,      // lê e escreve no domínio, mas não gerencia usuários
        Admin = 3          // controle total, incluindo gestão de usuários
    }

}
