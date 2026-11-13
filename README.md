# CadastroEventos — .NET MAUI

Projeto de atividade da Agenda 15 (Programação Mobile I).

## Recursos
- Formulário de cadastro com nome, início, término, participantes, local e custo.
- Model `Evento` vinculada à página pelo `BindingContext`.
- `DateTime` e `TimeSpan` para calcular a duração.
- Resumo em outra página via `Navigation.PushAsync`, com `StringFormat`.
- Custo total = participantes × custo por participante.
- Validação de campos, datas e valores.

## Executar
1. Instale Visual Studio 2022 com a carga de trabalho **Desenvolvimento de interface do usuário de aplicativo multiplataforma .NET** e SDK .NET 9/MAUI.
2. Abra `CadastroEventos.csproj` no Visual Studio.
3. Restaure os pacotes e selecione um emulador Android ou `Windows Machine`.
4. Execute com F5.

**Observação:** não foi possível compilar neste ambiente, pois não há SDK .NET instalado. Caso use .NET 10, atualize os `TargetFrameworks` no `.csproj` para `net10.0-*` e tenha os workloads correspondentes.

## Exemplo de teste
Nome: Feira de Tecnologia; início: 13/11/2026; término: 15/11/2026; participantes: 50; local: Auditório; custo: 25,50.
Resultado: 3 dias de evento (intervalo TimeSpan de 2 dias), custo total R$ 1.275,00.

## Entrega
1. Execute o app e tire duas capturas reais: formulário preenchido e tela de resumo.
2. Coloque as capturas no PDF de evidências (modelo fornecido separadamente).
3. Crie um repositório GitHub e envie todos os arquivos do projeto.
4. Entregue o link do repositório e o PDF com capturas reais.

## Correção de inicialização no Windows
Esta versão inclui `Platforms/Windows/App.xaml` e `App.xaml.cs`, necessários para a inicialização WinUI, além de `Package.appxmanifest` para os metadados Windows. Se aparecer CS5001, confirme que a carga de trabalho .NET MAUI e o SDK .NET 9 estão instalados e que o destino selecionado é **Windows Machine**, não um projeto C# genérico. Em seguida, restaure NuGet, limpe e recompile.
