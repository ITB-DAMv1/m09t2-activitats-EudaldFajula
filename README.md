# T2. Activitats

## Exercici 1. Investiga la llibreria System.Diagnostics. Enumera i explica els mètodes i propietats més rellevants o útils que trobis.

La llibreria System.Diagnostics proporciona classes per interactuar amb processos, esdeveniments, traçat de codi i registres d'esdeveniments.

1. Process: Permet inicialitzar, monitoritzar i gestionar processos del sistema.

- Propietats:

  - ProcessName: nom del procés.

  - Id: identificador del procés (PID).

  - StartTime, ExitTime: moments d'inici i fi.

  - Threads: col·lecció de fils (ProcessThreadCollection).

  - Modules: col·lecció de mòduls carregats (ProcessModuleCollection).

  - HasExited: indica si el procés ha acabat.

- Mètodes:

  - Start(), Start(ProcessStartInfo): inicia un nou procés.

  - Kill(): atura el procés immediatament.

  - CloseMainWindow(): sol·licita el tancament net.

  - GetProcesses(), GetProcessesByName(string): recupera processos en execució.

2. ProcessStartInfo: especifica informació per a la creació d'un procés.

- Propietats com FileName, Arguments, WorkingDirectory, UseShellExecute, RedirectStandardOutput.

3. ProcessThread: representa un fil d'un procés.

- Propietats:

  - Id: identificador del fil.

  - StartTime: moment d'inici.

  - ThreadState, CurrentPriorityLevel, BasePriority.

4. Debug i Trace: per traçar missatges durant el desenvolupament o producció.

- Debug.WriteLine(), Trace.WriteLine(), configuració de listeners i fitxers d'entrada.

5. EventLog: permet llegir i escriure entrades en el registre d'esdeveniments de Windows.

## Exercici 2. & Exercici 3.
![Exercici 2 & Exercici 3](./Ex2&3.cs)

## Exercici 4.

| Característica | Thread | Task |
| -------------- | ------- | --- |
| Creació | new Thread(Start) | Task.Run(...)/new Task(...) |
| Inici | .Start() | Inicia immediatament amb Run, o Start() si s'ha creat manualment |
| Retorn de valor | No retorna valor directament | Pot retornar Task<TResult> |
| Sincronització | .Join(), locks (lock, Monitor) | .Wait(), await, combinacions amb LINQ (WhenAll, WhenAny) |
| Thread pool | Creació de fil creat a l'instant | Utilitza el thread pool per reutilitzar fils |
| Cancel·lació | Manual amb flags i .Abort() (Deprecated) | CancellationToken |

## Exercici 5.
![Exercici 5](./Ex5.cs)

## Exercici 6.
![Exercici 6](./Ex6.cs)
