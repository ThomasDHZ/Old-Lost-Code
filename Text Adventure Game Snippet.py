#Some code I used for the battle engine.
#This is displaying the main interface during the battle sections of the game.
while inbattle == 0:

        if maincharturn == 1:
            adv.DisplayPlayerStats()
            ShowOptions()
            action = raw_input("\n\n\nWhat do you want to do?\n\n")

            if action == "Fight":
                temp = (TextGameEngine.playerATK - monsterDEF)
                monsterHP = monsterHP - temp
                print "monster takes ",temp,"damage.\n"
                    
            if action == "Spell":
                print "s works"
            if action == "Item":
                MainChar.display_inventory()
            if action == "Defend":
                DefendFlag = 1
            if action == "Run":
                print "You ran away."
                inbattle = 1
                break

        if maincharturn == 0:
            temp = (monsterATK - TextGameEngine.playerDEF)
            if DefendFlag == 1:
                temp /= 2
                DefendFlag = 0
            TextGameEngine.playerHP = TextGameEngine.playerHP - temp
            print "You took",temp,"damage.\n\n"

            
        if maincharturn == 1:
            maincharturn -= 1
        else:
            maincharturn += 1