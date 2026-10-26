# FFXIV IDA Comments

This script will add comments on various calls in IDA, for example:

- Addon texts on `RaptureTextModule_GetAddonText/FormatAddonText`
- ConfigOption names on `ConfigBase_GetConfigOption`
- InventoryTypes on `InventoryManager_GetInventoryContainer`
- LogMessage texts on `RaptureLogModule_ShowLogMessage`
- MainCommand names on `AgentHUD_IsMainCommandEnabled/SetMainCommandEnabledState`
- Quest names on `QuestManager_IsQuestAccepted/IsQuestComplete1`
- Addon names on `RaptureAtkModule_OpenAddon`
- Condition names on `Conditions.SetCondition`

It also adds a comment to ExecuteCommand with the used op code.

Comments are written to both the disassembly and Hex-Rays pseudocode views. Pseudocode comments appear before the corresponding statement, preserve existing comments, and are saved in the IDA database. Run the script again to add pseudocode comments to a database previously processed by an older version.

Obviously, the script needs data. That's where the Exporter comes in. It exports all the text and enum values the script needs as json (in the `out/` directory).

## Instructions

0) Have Dalamud, the game, .NET SDK, IDA, Python etc. installed.
1) Clone this repo or download it as zip.
2) Run `dotnet run --project Exporter.csproj`
3) Run the `ffxiv_comments.py` script in IDA.

## Command Line Switches

You can add these to `dotnet run --project Exporter.csproj` to change some settings of the Exporter:

### `--path`

The path to the sqpack directory.  
Default is `E:\Program Files (x86)\上海数龙科技有限公司\最终幻想XIV\game\sqpack`.

### `-l`, `--languages`

The languages to export (`chs`, `de`, `en`, `fr`, `ja`). Default is `chs` (Simplified Chinese). It is possible to specify more than one by separating them with a comma.  
After a successful export, the Exporter automatically updates the `language` setting in `ffxiv_comments.py`. When exporting multiple languages, the script uses the first language in the list. Run the Exporter from the repository directory so it can locate the script.
