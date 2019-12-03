Module Main

    Public Sub Main()

        'Intro \o/'
        Console.WriteLine("Advent of Code 2019")
        Console.WriteLine("Solution for Day 3 by Th3Shadowbroker (github.th3shadowbroker.org)")

        'Test it!'
        Test()

        'Required variables'
        Dim CentralPort = New Coordinate(0, 0)
        Dim WireA() As String = {"R1005", "D32", "R656", "U228", "L629", "U59", "L558", "D366", "L659", "D504", "R683", "U230", "R689", "U489", "R237", "U986", "L803", "U288", "R192", "D473", "L490", "U934", "L749", "D631", "L333", "U848", "L383", "D363", "L641", "D499", "R926", "D945", "L520", "U311", "R75", "D414", "L97", "D338", "L754", "U171", "R601", "D215", "R490", "U164", "R158", "U499", "L801", "U27", "L671", "D552", "R406", "U168", "R12", "D321", "L97", "U27", "R833", "U503", "R950", "U432", "L688", "U977", "R331", "D736", "R231", "U301", "L579", "U17", "R984", "U399", "L224", "U100", "L266", "U184", "R46", "D989", "L851", "D739", "R45", "D231", "R893", "D372", "L260", "U26", "L697", "U423", "L716", "D573", "L269", "U867", "R722", "U193", "R889", "D322", "L743", "U371", "L986", "D835", "R534", "U170", "R946", "U271", "L514", "D521", "L781", "U390", "L750", "D134", "L767", "U599", "L508", "U683", "L426", "U433", "L405", "U10", "L359", "D527", "R369", "D365", "L405", "D812", "L979", "D122", "L782", "D460", "R583", "U765", "R502", "D2", "L109", "D69", "L560", "U76", "R130", "D794", "R197", "D113", "L602", "D123", "L190", "U246", "L407", "D957", "L35", "U41", "L884", "D591", "R38", "D911", "L269", "D204", "R332", "U632", "L826", "D202", "L984", "U153", "L187", "U472", "R272", "U232", "L786", "U932", "L618", "U104", "R632", "D469", "L868", "D451", "R261", "U647", "L211", "D781", "R609", "D549", "L628", "U963", "L917", "D716", "L218", "U71", "L148", "U638", "R34", "U133", "R617", "U312", "L215", "D41", "L673", "U643", "R379", "U486", "L273", "D539", "L294", "D598", "L838", "D60", "L158", "U817", "R207", "U825", "L601", "D786", "R225", "D89", "L417", "U481", "L416", "U133", "R261", "U405", "R109", "U962", "R104", "D676", "R966", "U138", "L343", "U14", "L82", "U564", "R73", "D361", "R678", "D868", "L273", "D879", "R629", "U164", "R228", "U949", "R504", "D254", "L662", "D726", "R126", "D437", "R569", "D23", "R246", "U840", "R457", "D429", "R296", "U110", "L984", "D106", "L44", "U264", "R801", "D350", "R932", "D334", "L252", "U714", "L514", "U261", "R632", "D926", "R944", "U924", "R199", "D181", "L737", "U408", "R636", "U57", "L380", "D949", "R557", "U28", "L432", "D83", "R829", "D865", "L902", "D351", "R71", "U704", "R477", "D501", "L882", "D75", "R325", "D53", "L990", "U460", "R165", "D82", "R577", "D788", "R375", "U264", "L178", "D193", "R830", "D343", "L394"}
        Dim WireB() As String = {"L1003", "U125", "L229", "U421", "R863", "D640", "L239", "U580", "R342", "U341", "R989", "U732", "R51", "U140", "L179", "U60", "R483", "D575", "R49", "U220", "L284", "U336", "L905", "U540", "L392", "U581", "L570", "U446", "L817", "U694", "R923", "U779", "R624", "D387", "R495", "D124", "R862", "D173", "R425", "D301", "L550", "D605", "R963", "U503", "R571", "U953", "L878", "D198", "L256", "D77", "R409", "D752", "R921", "D196", "R977", "U86", "L842", "U155", "R987", "D39", "L224", "U433", "L829", "D99", "R558", "U736", "R645", "D335", "L52", "D998", "L613", "D239", "R470", "U79", "R839", "D71", "L753", "U127", "R135", "D429", "R729", "U71", "L151", "U875", "R668", "D220", "L501", "D822", "R306", "D557", "R461", "U942", "R59", "U14", "R353", "D546", "R409", "D261", "R204", "U873", "L847", "U936", "R611", "U487", "R474", "U406", "R818", "U838", "L301", "D684", "R861", "D738", "L265", "D214", "R272", "D702", "L145", "U872", "R345", "D623", "R200", "D186", "R407", "U988", "L608", "U533", "L185", "D287", "L549", "U498", "L630", "U295", "L425", "U517", "L263", "D27", "R697", "U177", "L615", "U960", "L553", "U974", "L856", "U716", "R126", "D819", "L329", "D233", "L212", "U232", "L164", "D712", "R316", "D682", "L641", "U676", "L535", "U783", "R39", "U953", "R39", "U511", "R837", "U325", "R391", "U401", "L642", "U435", "R626", "U801", "R876", "D849", "R448", "D8", "R74", "U238", "L186", "D558", "L648", "D258", "R262", "U7", "L510", "U178", "L183", "U415", "L631", "D162", "L521", "D910", "R462", "U789", "R885", "D822", "R908", "D879", "R614", "D119", "L570", "U831", "R993", "U603", "L118", "U764", "L414", "U39", "R14", "U189", "L415", "D744", "R897", "U714", "R326", "U348", "R822", "U98", "L357", "D478", "L464", "D851", "L545", "D241", "L672", "U197", "R156", "D916", "L246", "U578", "R4", "U195", "R82", "D402", "R327", "D429", "R119", "U661", "L184", "D122", "R891", "D499", "L808", "U519", "L36", "U323", "L259", "U479", "L647", "D354", "R891", "D320", "R653", "U772", "L158", "U608", "R149", "U564", "L164", "D998", "L485", "U107", "L145", "U834", "R846", "D462", "L391", "D661", "R841", "U742", "L597", "D937", "L92", "U877", "L350", "D130", "R684", "U914", "R400", "D910", "L739", "U789", "L188", "U256", "R10", "U258", "L965", "U942", "R234", "D106", "R852", "U108", "R732", "U339", "L955", "U271", "L340", "U23", "R373", "D100", "R137", "U648", "L130"}
        Dim WireMapA = GeneratePathMap(CentralPort, WireA)
        Dim WireMapB = GeneratePathMap(CentralPort, WireB)
        Dim Interconnections = GetInterconnections(WireMapA, WireMapB)

        'Some info'
        Console.WriteLine("Found " + Interconnections.Count.ToString() + " interconnections!")
        Console.WriteLine("Shortest interconnection is " + GetClosestDistance(Interconnections, CentralPort).ToString())

        'Prevent the app from closing'
        Console.Read()

    End Sub

    'Ensure everything is working as it is supposed to'
    Sub Test()

        Console.WriteLine("Performing tests...")

        Dim CentralPort = New Coordinate(0, 0)

        'Test 1: Expecting 159'
        Debug.Assert(
            GetClosestDistance(
                GetInterconnections(
                    GeneratePathMap(CentralPort, {"R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72"}),
                    GeneratePathMap(CentralPort, {"U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83"})
                ), CentralPort
            ) = 159
        )

        'Test 2: Expecting 135'
        Debug.Assert(
            GetClosestDistance(
                GetInterconnections(
                    GeneratePathMap(CentralPort, {"R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51"}),
                    GeneratePathMap(CentralPort, {"U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7"})
                ), CentralPort
            ) = 135
        )

        Console.WriteLine("Tests completed!")

    End Sub

    'Simulate the path of the wire, based on virtual coordinates'
    Function GeneratePathMap(ByRef centralPort As Coordinate, ByRef commands() As String) As List(Of Coordinate)
        Dim path = New List(Of Coordinate)
        path.Add(centralPort)

        For Each command As String In commands

            Debug.WriteLine("Executing: " + command)

            Dim direction = command.Chars(0)
            Dim amount = Integer.Parse(command.Substring(1, command.Length - 1))
            Dim lastLocation = path.ElementAt(path.Count - 1)

            Select Case direction

                Case "U"
                    For i = 1 To amount
                        path.Add(New Coordinate(lastLocation.X, lastLocation.Y + i))
                    Next

                Case "D"
                    For i = 1 To amount
                        path.Add(New Coordinate(lastLocation.X, lastLocation.Y - i))
                    Next

                Case "L"
                    For i = 1 To amount
                        path.Add(New Coordinate(lastLocation.X - i, lastLocation.Y))
                    Next

                Case "R"
                    For i = 1 To amount
                        path.Add(New Coordinate(lastLocation.X + i, lastLocation.Y))
                    Next

            End Select

        Next

        Return path
    End Function

    'Generate a list that contains'
    Function GetInterconnections(ByRef pathMapA As List(Of Coordinate), ByRef pathMapB As List(Of Coordinate)) As List(Of Coordinate)
        Dim results = New List(Of Coordinate)
        Dim fewestSteps = Nothing

        Dim outer = 0
        For Each coordinateA In pathMapA.Skip(1)

            Dim inner = 0
            For Each coordinateB In pathMapB.Skip(1)

                If coordinateA.X = coordinateB.X And coordinateA.Y = coordinateB.Y Then
                    results.Add(coordinateA)

                    If fewestSteps = Nothing Then
                        fewestSteps = inner + outer + 2 'Add two additional steps, as skipped to indexes'
                    End If
                End If

                inner += 1
            Next

            outer += 1
        Next

        Console.WriteLine("Fewest required steps before interconnection: " + fewestSteps.ToString())

        Return results
    End Function

    'Calculate the manhattan distance between two coordinates'
    Function GetManhattanDistance(coordinateA As Coordinate, coordinateB As Coordinate) As Integer
        Return Math.Abs(coordinateA.X - coordinateB.X) + Math.Abs(coordinateA.Y - coordinateB.Y)
    End Function

    'Calculates the manhattan distances of a list and returns the one that is the closest to the given point'
    Function GetClosestDistance(interconnections As List(Of Coordinate), target As Coordinate)
        Dim shortest As Integer = Nothing
        For Each interconnection In interconnections
            Dim distance = GetManhattanDistance(target, interconnection)

            If distance < shortest Or shortest = Nothing Then
                shortest = distance
            End If
        Next
        Return shortest
    End Function

End Module
