/**
* <author>Ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxNPC))
{
    new ScriptObject(LiFxNPC)
    {
    };
}
package LiFxNPC
{
  function LiFxNPC::setup() {
    LiFx::registerCallback($LiFx::hooks::onDatablockLoad, RegisterNewNPCmaterials, LiFxNPC);
  }

  function LiFxNPC::RegisterNewNPCmaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/art/Textures/NPC", "NPCmaterials.cs");
 // LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/NPC", "sounds.cs"); Currently DISABLED
  }
  function LiFxNPC::path() {
    return $Con::File;
  }
};
activatePackage(LiFxNPC);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxNPC);