<table width="100%">
    <thead>
        <tr>
            <th>
                ID
            </th>
            <th>
                Login
            </tthd>
            <th>
                E-mail
            </th>
            <th>
                Permissão
            </th>
        </tr>
    </thead>
    <tbody>
        <?php
            $select = $mysqli->query("SELECT * FROM usuarios ORDER BY ID ASC");
            $row = $select->num_rows;
            if($row > 0) {
            while($get = $select->fetch_array()) {
        ?>
        <tr>
            <td>
                <?=$get["ID"]?>
            </td>
            <td>
                <?=$get["Usuario"]?>
            </td>
            <td>
                <?=$get["Email"]?>
            </td>
            <td>
                <?=$get["Permissao"]?>
            </td>
        </tr>
        <?php
                }
            } else {
        ?>
        <h4> Não existe nenhum usuário! </h4>
        <?php
            }
        ?>
    </tbody>
</table>