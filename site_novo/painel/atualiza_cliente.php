<?php
    include 'conecta.php';

    include 'menu.php';
?>

            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">INSERIR NOVO CLIENTE</h1>
                        <ol class="breadcrumb mb-4" >
                            <li class="breadcrumb-item">
                                <a href="" class="btn btn-success">INSERIR NOVO CLIENTE</a>
                            </li>
                        </ol>
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>NOME</th>
                                            <th>EMAIL</th>
                                            <th>TELEFONE</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                            <th>ID</th>
                                            <th>Position</th>
                                            <th>Office</th>
                                            <th>Age</th>
                                            <th>Start date</th>
                                        </tr>
                                    </tfoot>

                                
                                    <tbody>
                                    <?php
                                        $sql = "SELECT * FROM cadastro";
                                        $consulta = $conexao->query($sql);
                                        while($dados = $consulta->fetch_assoc()){
                                            echo "<tr>";
                                            echo "<td>".$dados['id_cliente'].".<br>";
                                            echo "<td>".$dados['nome_cliente'].".<br>";
                                            echo "<td>".$dados['email_cliente'].".<br>";
                                            echo "<td>".$dados['telefone'].".<br>";
                                            echo "<td>
                                                <a class='btn btn-info  ' href=''>ATUALIZAR</a>
                                                <a class='btn btn-danger' href=''>APAGAR</a>
                                            
                                            ";
                                            echo "</tr>";
                                        }
                                    
                                    
                                    ?>   
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </main>
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2023</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="assets/demo/chart-area-demo.js"></script>
        <script src="assets/demo/chart-bar-demo.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@7.1.2/dist/umd/simple-datatables.min.js" crossorigin="anonymous"></script>
        <script src="js/datatables-simple-demo.js"></script>
    </body>
</html>
