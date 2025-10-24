# Azure Speech Studio e Language Studio

Este guia explica de forma simples como usar o **Azure Speech Studio** e o **Azure Language Studio** para análise de fala e linguagem natural.

---

## 🔊 Azure Speech Studio

### O que é
O **Speech Studio** é uma ferramenta da Microsoft Azure que permite converter fala em texto, texto em fala e até criar modelos personalizados de reconhecimento de voz.  

Ele é ideal para:
- Transcrever áudios e reuniões;
- Criar legendas automáticas;
- Treinar modelos com vocabulário específico (ex: termos técnicos).

---

### Como usar (passo a passo)

1. **Crie uma conta no Azure**  
   Vá em [https://portal.azure.com](https://portal.azure.com) e faça login.

2. **Crie um recurso Speech**  
   - No portal, clique em **Criar recurso** → pesquise por **Speech**.  
   - Escolha a região, grupo de recursos e crie.  
   - Após criado, vá em **Chaves e endpoint** para copiar as credenciais.

3. **Acesse o Speech Studio**  
   - Vá para [https://speech.microsoft.com/portal](https://speech.microsoft.com/portal).  
   - Faça login e selecione o recurso que você criou.

4. **Teste uma transcrição**  
   - Escolha **Speech to Text**.  
   - Envie um arquivo de áudio (ex: WAV ou MP3).  
   - Veja o texto gerado automaticamente.

5. **Ajuste e exporte**  
   - Você pode revisar o texto, corrigir palavras e exportar a transcrição.

---

## 💬 Azure Language Studio

### O que é
O **Language Studio** é a ferramenta de **análise de linguagem natural** do Azure.  
Ele permite entender o significado de textos, identificar sentimentos, extrair entidades e muito mais.

Use para:
- Analisar opiniões de clientes;
- Detectar emoções em frases;
- Resumir textos ou classificar conteúdo.

---

### Como usar (passo a passo)

1. **Crie um recurso Language**
   - No portal do Azure, clique em **Criar recurso** → pesquise por **Language**.
   - Escolha região e grupo de recursos e crie.
   - Copie as **chaves e endpoint** do recurso.

2. **Acesse o Language Studio**
   - Vá para [https://language.cognitive.azure.com/](https://language.cognitive.azure.com/).
   - Faça login e selecione o recurso Language criado.

3. **Teste uma análise**
   - Escolha um dos recursos disponíveis (por exemplo, **Análise de sentimento**).
   - Digite um texto, como:  
     “O atendimento foi ótimo, mas a entrega demorou.”
   - Clique em **Executar** e veja o resultado (positivo, neutro ou negativo).

4. **Explore outras opções**
   - **Reconhecimento de entidades**: identifica nomes, locais, datas.  
   - **Resumo de texto**: cria resumos automáticos.  
   - **Classificação personalizada**: treine seu próprio modelo com exemplos.

---

## 💡 Dica final
Você pode usar o **Speech Studio** para transformar áudios em texto, e depois enviar esse texto para o **Language Studio** para analisar sentimentos, temas ou intenções.  
É uma combinação poderosa para análise de voz e linguagem natural.

---

## 📚 Referências
- [Azure Speech Studio](https://speech.microsoft.com/portal)  
- [Azure Language Studio](https://language.cognitive.azure.com/)  
- [Documentação oficial do Azure Speech](https://learn.microsoft.com/azure/ai-services/speech-service/)  
- [Documentação oficial do Azure Language](https://learn.microsoft.com/azure/ai-services/language-service/)
