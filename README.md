# QuintaCode20201126

projeto criado para exemplificar o funcionamento entre angular e API de maneira limples

roteiro de execução
instalar 
	.netcore
	angular
executar comandos
	dotnet new webapi -n "WebApp"
	ng new WebClient

WebClient comands
	cd .\WebCLient\
	ng g class Usuario
	CTRL + SHIFT + P > Convert C# to typescript > alterar interface para classe
	ng g service Usuario
	ng g component Usuario
	ng serve
	//TODO
	limpar app.component
	adcionar <app-usuario></app-usuario>
	editar o usuario.component com o emmet table>(thead>tr>th*7)+(tbody>tr>td*7)
		<tr *ngFor="let u of usuarios">
	limpar a index.html > snipnet $b4 & $fa	> adionar a tag <base href="/" /> e <app-root></app-root> no body
	
	app.module.ts
	import { HttpClientModule } from '@angular/common/http'; configurar os imports[]
	
WebApp
	permitir qualquer origem startup.cs
			// global cors policy
			app.UseCors(x => x
				.AllowAnyMethod()
				.AllowAnyHeader()
				.SetIsOriginAllowed(origin => true) // allow any origin
				.AllowCredentials()); // allow credentials
				
	Thread Sleeep na controller
	Thread.Sleep(rng.Next(1000,10000));
