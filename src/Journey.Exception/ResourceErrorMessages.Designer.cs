﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Journey.Exception {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourceErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceErrorMessages() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Journey.Exception.ResourceErrorMessages", typeof(ResourceErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a A data da viagem deve ser posterior a hoje..
        /// </summary>
        public static string A_DATA_DA_VIAGEM_DEVE_SER_POSTERIOR_A_HOJE {
            get {
                return ResourceManager.GetString("A_DATA_DA_VIAGEM_DEVE_SER_POSTERIOR_A_HOJE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a A data final da viagem não pode ser antes da data inicial da viagem.
        /// </summary>
        public static string A_DATA_FINAL_DA_VIAGEM_DEVE_SER_MAIOR_QUE_A_DATA_INICIAL {
            get {
                return ResourceManager.GetString("A_DATA_FINAL_DA_VIAGEM_DEVE_SER_MAIOR_QUE_A_DATA_INICIAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a A atividade que você selecionou não está disponivel para esta data, por favor selecione uma data dentro do periodo da sua viagem.
        /// </summary>
        public static string ATIVIDADE_INDISPONIVEL {
            get {
                return ResourceManager.GetString("ATIVIDADE_INDISPONIVEL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Atividade não encontrada.
        /// </summary>
        public static string ATIVIDADE_NAO_ENCONTRADA {
            get {
                return ResourceManager.GetString("ATIVIDADE_NAO_ENCONTRADA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Erro desconhecido.
        /// </summary>
        public static string ERRO_DESCONHECIDO {
            get {
                return ResourceManager.GetString("ERRO_DESCONHECIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a O nome não pode estar vazio.
        /// </summary>
        public static string NOME_NULO {
            get {
                return ResourceManager.GetString("NOME_NULO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Está viagem não foi encontrada.
        /// </summary>
        public static string VIAGEM_NAO_ENCONTRADA {
            get {
                return ResourceManager.GetString("VIAGEM_NAO_ENCONTRADA", resourceCulture);
            }
        }
    }
}
