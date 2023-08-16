using System.Text.Json.Serialization;

namespace IntegraBancoAPI.Models
{
    public class CorretoraModel
    {
        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("cnpj")]
        public string? Cnpj { get; set; }

        [JsonPropertyName("codigo_cvm")]
        public string? Codigo_cvm { get; set; }

        [JsonPropertyName("complemento")]
        public string? Complemento { get; set; }

        [JsonPropertyName("data_inicio_situacao")]
        public string? Data_inicio_situacao { get; set; }

        [JsonPropertyName("data_patrimonio_liquido")]
        public string? Data_patrimonio_liquido { get; set; }

        [JsonPropertyName("data_registro")]
        public string? Data_registro { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("municipio")]
        public string? Municipio { get; set; }

        [JsonPropertyName("nome_social")]
        public string? Nome_social { get; set; }

        [JsonPropertyName("nome_comercial")]
        public string? Nome_comercial { get; set; }

        [JsonPropertyName("pais")]
        public string? Pais { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [JsonPropertyName("valor_patrimonio_liquido")]
        public string? Valor_patrimonio_liquido { get; set; }
    }
}