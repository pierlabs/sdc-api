=begin
API SDC 2016

API desenvolvida para a 15\u00C2\u00AA semanda da computa\u00C3\u00A7\u00C3\u00A3o da UFPB em 2016

OpenAPI spec version: 1.0.0
Contact: pierlabs@conductor.com.br
Generated by: https://github.com/swagger-api/swagger-codegen.git

License: Apache 2.0
http://www.apache.org/licenses/LICENSE-2.0.html

Terms of Service: http://pierlabs.io/terms/

=end

require 'spec_helper'
require 'json'

# Unit tests for SDC::CartaoApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CartaoApi' do
  before do
    # run before each test
    @instance = SDC::CartaoApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CartaoApi' do
    it 'should create an instact of CartaoApi' do
      @instance.should be_a(SDC::CartaoApi)
    end
  end

  # unit tests for bloquear_using_put
  # Bloquear um cart\u00C3\u00A3o.
  # Bloquear um cart\u00C3\u00A3o.
  # @param id_conta ID da Conta
  # @param id_cartao Cart\u00C3\u00A3o a ser bloqueado
  # @param [Hash] opts the optional parameters
  # @return [Response]
  describe 'bloquear_using_put test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for cancelar_using_delete
  # Cancelar um cart\u00C3\u00A3o
  # Cancelar um determinado cart\u00C3\u00A3o
  # @param id_conta ID da Conta
  # @param id_cartao Cart\u00C3\u00A3o a ser cancelado
  # @param [Hash] opts the optional parameters
  # @return [Response]
  describe 'cancelar_using_delete test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for create_using_post
  # Cria um cart\u00C3\u00A3o
  # Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
  # @param id_conta ID da Conta
  # @param cartao Cart\u00C3\u00A3o a ser criado
  # @param [Hash] opts the optional parameters
  # @return [Cartao]
  describe 'create_using_post test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for creditar_using_put
  # Creditar dinheiro em um cart\u00C3\u00A3o
  # Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
  # @param id_conta ID da Conta
  # @param id_cartao ID do Cartao a ser creditado
  # @param valor Valor a ser creditado
  # @param [Hash] opts the optional parameters
  # @return [Response]
  describe 'creditar_using_put test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for desbloquear_using_put
  # Desbloquear um cart\u00C3\u00A3o.
  # Desbloquear um determinado cart\u00C3\u00A3o.
  # @param id_conta ID da Conta
  # @param id_cartao Cart\u00C3\u00A3o a ser desbloqueado
  # @param [Hash] opts the optional parameters
  # @return [Response]
  describe 'desbloquear_using_put test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for extratos_using_post
  # Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
  # Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
  # @param id_conta ID da Conta
  # @param id_cartao ID do cart\u00C3\u00A3o
  # @param [Hash] opts the optional parameters
  # @return [Array<Transacao>]
  describe 'extratos_using_post test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for get_all_using_get
  # Retona todos os cart\u00C3\u00A3o de uma conta
  # Consulte todos os carteos de uma determinada conta.
  # @param id_conta ID da Conta
  # @param [Hash] opts the optional parameters
  # @return [Array<Cartao>]
  describe 'get_all_using_get test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for get_one_using_get
  # Retorna um cart\u00C3\u00A3o
  # Consulte um determinado cart\u00C3\u00A3o
  # @param id_conta ID da Conta
  # @param id_cartao ID do Cart\u00C3\u00A3o
  # @param [Hash] opts the optional parameters
  # @return [Cartao]
  describe 'get_one_using_get test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for limite_using_get
  # Retorna o limite do cart\u00C3\u00A3o
  # Consultar o limite de um determinado cart\u00C3\u00A3o
  # @param id_conta ID da Conta
  # @param id_cartao ID do Cartao a ser creditado
  # @param [Hash] opts the optional parameters
  # @return [Limite]
  describe 'limite_using_get test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for transacionar_using_put
  # Transacionar valores
  # Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
  # @param id_conta ID da Conta
  # @param id_cartao ID do Cartao a ser creditado
  # @param valor Valor da transa\u00C3\u00A7\u00C3\u00A3o
  # @param [Hash] opts the optional parameters
  # @return [Response]
  describe 'transacionar_using_put test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for transferir_using_post
  # Transferir valores entre dois cart\u00C3\u00B5es distintos
  # Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
  # @param id_conta ID da Conta do cart\u00C3\u00A3o de origem
  # @param id_cartao ID do cart\u00C3\u00A3o de origem
  # @param id_cartao_destino ID do cart\u00C3\u00A3o de destino
  # @param valor Valor a ser transferido
  # @param [Hash] opts the optional parameters
  # @return [Response]
  describe 'transferir_using_post test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

  # unit tests for update_using_put
  # Atualiza um cart\u00C3\u00A3o
  # Atualiza um determinado cart\u00C3\u00A3o
  # @param id_conta ID da Conta
  # @param cartao Cart\u00C3\u00A3o a ser atualizado
  # @param [Hash] opts the optional parameters
  # @return [Cartao]
  describe 'update_using_put test' do
    it "should work" do
      # assertion here
      # should be_a()
      # should be_nil
      # should ==
      # should_not ==
    end
  end

end
