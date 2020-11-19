-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Nov-2020 às 19:20
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `movie_streaming`
--
CREATE DATABASE IF NOT EXISTS `movie_streaming` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `movie_streaming`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `animes`
--

CREATE TABLE `animes` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `imagem` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `animes`
--

INSERT INTO `animes` (`id`, `nome`, `imagem`) VALUES
(1, 'Shingeki No Kyojin', 'https://animesonline.cc/wp-content/uploads/2019/06/1XnZJZ6QDxgaVbnsGpNrBi13JfI-185x278.jpg'),
(2, 'Charlotte', 'https://animesonline.cc/wp-content/uploads/2019/10/k0SHMCAOjsXMQf3nCC7nEAmvZOw-185x278.jpg'),
(3, 'Boku no Hero Academy', 'https://animesonline.cc/wp-content/uploads/2019/07/5Ui54VS5oxmPzzdEGJEUkW0uESI-185x278.jpg'),
(4, 'Haikyuu!!', 'https://animesonline.cc/wp-content/uploads/2020/01/6R2GkrQW8ZRlZAhEdVKwJjrANwS-185x278.jpg'),
(5, 'Nanatsu no Taizai', 'https://animesonline.cc/wp-content/uploads/2019/09/fJ0Jy7NNdqIuYcYNqeK7YJHVLL0-185x278.jpg'),
(6, 'Black Clover', 'https://animesonline.cc/wp-content/uploads/2020/02/ixM7N62bjtu5PGr1Tq3wuBbELxX-185x278.jpg'),
(7, 'Another', 'https://animesonline.cc/wp-content/uploads/2019/07/oDQS90LmX3BgDFyX9gmOaFexdZY-185x278.jpg'),
(8, 'Naruto Shippuden', 'https://animesonline.cc/wp-content/uploads/2019/09/ic9Gb4Zz09ns3JPYHdax8u5kt0n-185x278.jpg'),
(9, 'Baki 2018', 'https://animesonline.cc/wp-content/uploads/2019/07/z6jzS7IISZQnCDWzKSP4Q6lnKG4-185x278.jpg'),
(10, 'Fairy Tail', 'https://animesonline.cc/wp-content/uploads/2019/08/703mVJP8UyP1b1hEJi6aTrf0MQ1-185x278.jpg'),
(11, 'Tokyo Ghoul', 'https://animesonline.cc/wp-content/uploads/2019/06/dDxCpbuzk6pS2bRiJ99FibI2tDh-185x278.jpg'),
(12, 'Sword Art Online', 'https://animesonline.cc/wp-content/uploads/2019/10/7d3070bc3f5e32a8187ceea7445013301594706429-185x278.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `filmes`
--

CREATE TABLE `filmes` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `imagem` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `filmes`
--

INSERT INTO `filmes` (`id`, `nome`, `imagem`) VALUES
(1, 'IT - A Coisa', 'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTlELU3NYNPAckjg2U6b7GSfcUxB9BiR6NSA5Jqq0o6rhnOgGC7'),
(2, 'Super Herói - O Filme', 'https://fotos-g.imagemfilmes.com.br/103805/103805_001.jpg'),
(3, 'Deadpool 2 - O Filme', 'https://br.web.img3.acsta.net/c_215_290/pictures/18/04/19/15/31/2232385.jpg'),
(4, 'Sonic - O Filme', 'https://i.pinimg.com/originals/bc/86/79/bc86798e2865dcb27d6da5338da2ad0d.jpg'),
(5, 'Coringa - O Filme', 'https://ingresso-a.akamaihd.net/img/cinema/cartaz/22050-cartaz.jpg'),
(6, 'Rambo: Até o Fim', 'https://br.web.img3.acsta.net/pictures/19/08/12/22/46/1191330.jpg'),
(7, 'Homem Aranha: De Volta ao Lar', 'https://br.web.img3.acsta.net/pictures/17/05/29/23/31/530814.jpg'),
(8, 'Harry Potter: A Ordem da Fênix', 'https://br.web.img3.acsta.net/medias/nmedia/18/90/67/58/20107766.jpg'),
(9, 'Coraline 2: O Poço Encantado', 'https://br.web.img2.acsta.net/medias/nmedia/18/87/79/16/19961587.jpg'),
(10, 'Corra! - O Filme', 'https://br.web.img3.acsta.net/pictures/17/04/19/21/08/577190.jpg'),
(11, 'Arlequina - Aves de Rapina', 'https://br.web.img3.acsta.net/pictures/19/09/17/19/29/5316438.jpg'),
(12, 'Parasita - O Filme', 'https://www.ovale.com.br/_midias/jpg/2020/02/10/x23fqkt00uqv2tzfsib60hrc3hy-911398.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `stream_animes`
--

CREATE TABLE `stream_animes` (
  `id` int(11) NOT NULL,
  `numero` int(11) NOT NULL,
  `streaming_url` text NOT NULL,
  `id_anime` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `stream_animes`
--

INSERT INTO `stream_animes` (`id`, `numero`, `streaming_url`, `id_anime`) VALUES
(1, 1, 'https://www.blogger.com/video.g?token=AD6v5dx1YCLviKnDl1vrKecx7DdZwq5PoVNhr2L86hDii4IxC7JXe3q19puEat2xe35lR6baQtJkU5JjPTv30_TC4YBIbwpVAYvcZm0H0zAeb_i5vLL27CcQ8C-hfqpx_yOmVY-5V56N', 1),
(2, 2, 'https://www.blogger.com/video.g?token=AD6v5dxKVpoX_fKlbtz1Uhf-MylKEbtvZYobtjB2zLB82dHn4Lp_BKMQR04wPGIDxrIeQSYEGa6EdRga4LhYgX7F8ZpxgX3VDx-41tm_KE9upZ4qBG4xTMQkCp-ryB0m9RbqAnvPFpOt', 1),
(3, 3, 'https://www.blogger.com/video.g?token=AD6v5dx0XH7lH36UrSooKS493VnOk0Zn9SjZUE1QgE5u4d7p_qWVxVxl_hZeyqMNu45JptK7qod84Q2TnoMdo-Keyw5b7lBUV4PfuNwkavaylROErOq708R-2qoWCj4rU-UcJPHwEtM', 1),
(4, 1, 'https://www.blogger.com/video.g?token=AD6v5dxUasL8a07IEt3v6TRKXIsyF0b8SdP2CP5WzG9izF6mbOd3NqhHc2DBkhgY8B_hTboV0SHJRnsq74EkJoYseE3603Q8aZ1hDrdEb9gR90lPeVREZGxHsNkRYVIoEayu40-I0HSM', 2),
(5, 2, 'https://www.blogger.com/video.g?token=AD6v5dw90spv5Homsr5JuRiNBFsW1bw0FBo4kPA3UV2Ilqp5vwsbXcXwpy_nHyDe-4q4gi-i_LyC3B8mBLkdLEOWvGw2EjXA8dwuxsoY-sokPfCvgjO5lTXeT-GUa5RPo9a0C2rYgg_4', 2),
(6, 3, 'https://www.blogger.com/video.g?token=AD6v5dzLCPIOTAKqA16h7sBrBajl_35YqLg98tN4mcxYMQvfzkzNSInmR2uAsg5t52tO0wXOkEKZEvzqsKLnJ5fQs1VDmhXOnCW7pOHJxEn8i8AQFOGnNHMZEJjGAQPjaNW6kZ-GLuJm', 2),
(7, 1, 'https://www.blogger.com/video.g?token=AD6v5dw4GF-zOXz1BlGv0OBRjeSotiHjZXUPX2Np8-KSyP26lnPIScuqJ5UNsjRsT8qUB96Q_nLWIR7D1qmy18S2dJBpJstTV-4jWkmLdn065zyHfSsUFLEXmI21yAqoCmZS41gzGlRa', 3),
(8, 2, 'https://www.blogger.com/video.g?token=AD6v5dxPLh68Dy4KTvFSpGTROBdDoTiD79RBkNGUYOo6wKe6jKmxZ6eGi-PFQ26TuAakoFK8Dcu4VlHjgM8IjwdSMzrl7ZwuW4jeoxG4ZYEo86D0ZCWTSWIk8_-Z9t0FEJbmuZtfStY', 3),
(9, 3, 'https://www.blogger.com/video.g?token=AD6v5dyDfpg6KojyYFXWe13NRBwhW65oI4vJKc_PtVHLI-rtrTFEstP7cMjcqaOs08nfMFrfmfVsRzqTzZodJeDBoVoLkv4PDe-NKmJPbwMVwxAvOt5TmxGhSxUINDhbFiipAuBObk6Z', 3),
(10, 1, 'https://www.blogger.com/video.g?token=AD6v5dxWJtJrNoPKnN4NHJxfgWm64KqHLggxCw7lH8tWHPZtrPmFnV4YlqZqpfQHnUxxAeMbTWdh-vMvSBUUcG_l_sfE4gatHcWSLwfXTHr1Oi796JNQsQ1YGFVzpG_HS2zv4dKo7jE', 4),
(11, 2, 'https://www.blogger.com/video.g?token=AD6v5dzodIwkrllQ3zGLUY0kyWlwpds5nYXIXOApy6Z88Ycsjy0jJcNYSQK5Mgj7lRy0wcpsu-8Z660LoaRMkYXx0BqWWnjZXuFurY_mjtWh1HcJ62JvQ60wxRJrnVLaOONthVkSQCau', 4),
(12, 3, 'https://www.blogger.com/video.g?token=AD6v5dzwZPY0zIovN2IADdPdllQ0wG-IflHUjXdvyVFzBWYqJV31s-dLHe1nYqTz2lL3uzYghxJgWXf3Hpo7GnKinJ1gJfkpD3ckv4E4FC1v3Ie6L1PAFKNXTahA8d4IkrckmTHtLV2s', 4),
(13, 1, 'https://www.blogger.com/video.g?token=AD6v5dw44p3goh9op2UQsMBJDVWt_UZcSL1vb4SSptFfstylHzU1T5-uO53mUFTzK8l4lymoxN0e1XEAprSEiLkhmRmCfHhHmho7CUNb5-fCEJiKEY17zChZhTSb0xSnZasGe01QTqKS', 5),
(14, 2, 'https://www.blogger.com/video.g?token=AD6v5dw7Ib9zH-ZmFdNcdB4Ggn92sVbjZIriijvNMwaa8CpMote_b2ReXX9yka3ThEoTsfCNuJm7m8hKAYLlw7QEkrya-F8GqT2yEFRjowz3y_9ZIu5iMMiSE8ZriW67ptvDhPzuC4b_', 5),
(15, 3, 'https://www.blogger.com/video.g?token=AD6v5dz0P4g1GJL9mh8rm98ZCkEr6atSDtS3WQ1ZPRiO1MRFwzpecA-cPZwfdeI0UnwXPWHsLZitLO7hTjUqB1FIgVn-GIGqIT0GC3wdAxg52BmDYFqKSCb5DMH2m2TwH1z0drKwj72F', 5),
(16, 1, 'https://www.blogger.com/video.g?token=AD6v5dwP_6GaxN4puObYxXC1XyXnXqdJGBXSeyxhFnWhvt6NLQB_qyW9fGjxemRw1F0j2nBepxD3EdG-0yv9FKfwjvRJmLhakpnuLJ4hkZT0fdvDiAyF9Ckzqv-8JVlcnWD0HDPoWCA', 6),
(17, 2, 'https://www.blogger.com/video.g?token=AD6v5dzF5OoRq0LkVHiCCwLigGdETDLyTKohoxEVF1hMzJ2sH7z3WgrHxtHZuoOHqywfPp8MzG-7uJoLIzV_b3w-EAzLhOT-PTb90V1Q6huALap3B6z0I_6sVJohNKeuZ8mDumvlMe-G', 6),
(18, 3, 'https://www.blogger.com/video.g?token=AD6v5dxbNN7M-zC5EqtWxqVaPs9gIfjGuW21P3niYwb1kjrdTTVd0XKuy8fCQjp9hbL7ihn8TmpJ0ht0smWuqKGdNE3sVECJaoHCxKhBNHFsamDj0z86bhU95hQ51N4F96GxYan71NO0', 6),
(19, 1, 'https://www.blogger.com/video.g?token=AD6v5dypN6fAswEAUlAGQZORK-7xbZHGU6oMP9xac2x_hd3dwf725YNuq46xdzRMhReLNVlEnSQfjzwm4F8gX_SILqSdNa98fTJteibsuAhnJWrq6jisIzrkPYnupQJHKz-T810zQqgJ', 7),
(20, 2, 'https://www.blogger.com/video.g?token=AD6v5dyMJr8k5VByb3j-PNVjeatHbTeCHt_lgdpRcxreLZm_GD3yEAImp1gPVR3_SOp6i1dVeBknxHEhuJ6gNuw0IvxLYJwWu6-j2RDkHiwHXe8w70ghYT0UI6KnPiH7AI5w7p47708', 7),
(21, 3, 'https://www.blogger.com/video.g?token=AD6v5dyWFFwutKpCk-HtAgIE0DSTBNN3fYDgO0FVOvfjOyph_N9u44hXqxchF_OW0hkAoBmG6BLsCZVuw3iDxCp2o_ya3mKLetf59IsPJv2B3zrdxbKWRUDOjdPfMw-jMWnMWoqLnag', 7),
(22, 1, 'https://www.blogger.com/video.g?token=AD6v5dx-7WRiCF8duytuB4WNqphIpz26rB1L7d77Yaw_N9rrwED0BVtjbMimphdNBGn42QzA1y3x2sbvZN26Hi_GvrpxeHydc9Pt82B4yq1Qq31uDPr67KDYYVPxKYR__aTxlKme3Zc', 8),
(23, 2, 'https://www.blogger.com/video.g?token=AD6v5dzPFMygIUpc6OtjBwRcqaII78tp3F4AxRQApVPCtiWwu40O71ZIU_zgTXHJdo0DrR4sH7MPtJg_3JQ9mSaeVdXkuQaHhUXmk1O3PyDhguciY_Tc4gjCno0ctdqW-nVYUPP97YM', 8),
(24, 3, 'https://www.blogger.com/video.g?token=AD6v5dzDlXJ2eh-3j0HRj5Qtu-_PUm6VXBwbu8zSAH0Douro0SXENbev2oVzQjN7eLcGOqY-K37kYu3M5YaM9jm5LCQsrG_bP0IfJkc4C8gdAFPIoYCiZMTCFZ3SkP6E8AJERlTP7hI', 8),
(25, 1, 'https://www.blogger.com/video.g?token=AD6v5dx2m_FM6JJ-uYE1EHxPzCjlBaAuLpE3zyegNTtL8NbquO2ly-cME0hdbL9tzdHD8jQ-apJsHDHI7Pa4HBZ2hGPnxxevOjLAHw1T9yXrNlvvni_W9mXYuKc2GIyY95vaJsfgidg', 9),
(26, 2, 'https://www.blogger.com/video.g?token=AD6v5dyBU2CqsqMwod8Wulk7d263prnxPu_YJwvjLTwUS4-Obazdftac3rLoweO8QPhgoP-_QR57dL3OGamtTvI300DRrrcH2enZB79A62NdKP_FAGfEptEbv-pFN1YZeZMwoaDEyuQ', 9),
(27, 3, 'https://www.blogger.com/video.g?token=AD6v5dyeQrmqVf7VP2gyf6tBtsXZHf-NIuSqwCvL-Fs0qFpOVekU2lpc0vLTP3sSqFmrEjaGbqlbMcbZD6QqOYWp0L1msDTIMujw8BxGzBQkfxe0BMfa7FgUMPCQvNecSELVD98jx8g', 9),
(28, 1, 'https://www.blogger.com/video.g?token=AD6v5dwbXvT1Ld15KgO9lGO0Xc5Z24U_SVMIyDpoZ-nY1eZlulChkwepskG9jl9_FNac5Qu70EYq2VZI7M8V3dCyq9fkaCXDNqeOrO1l2w1TlkOFe1J6GmEDZGwaMEB7eTBihzIHJmnK', 10),
(29, 2, 'https://www.blogger.com/video.g?token=AD6v5dyBwFccir5HGgROdepeRVMBo73_kjiWo6pWUH4Cl6o_-QDAAkmqHdePB2QrVeSsXNntW-PNcRuNlxJO0ABMy7p3r_BsRfHDfth2IHBHRW8z2n2WEV3R8VUZoQSBWdGfi1HMuIGP', 10),
(30, 3, 'https://www.blogger.com/video.g?token=AD6v5dwzbMUNzWSus4ss5a042TPhISfY8LaQRlZlIjSqe5Gbx4imc9X25e6vZBr5R0WYMvTiL7WTYPv8D8_I0IYid3XMJqwEW53Bnf2SXv4T0JEuu1wMZ9JlrjfSWvknWVJQboor3Uk', 10),
(31, 1, 'https://www.blogger.com/video.g?token=AD6v5dwqpvC1yDfRhpouH-DSArL3jZ0P-nUCedSjtOJJ-5YpkMFBOxMflE8RLhZ8W73d2VUcnyKFZHAF4KmfQNXmS-hWUc4HFRoSjzR90jVHfS13Xve_GgwcVShjddw6A1gbgmJweI8c', 11),
(32, 2, 'https://www.blogger.com/video.g?token=AD6v5dwqk0J1czAl3lWp6EpLCJuAHUPg03l-Lfpkn9CMz4EqjIQRkja7V00oziC5ixlW1KUcJE82-B0RdQSSHB7o1-RCBZAURcxSeQmWbqOx7ZjiGN2jU7pfWUsxBqMldPV6N_mofjSh', 11),
(33, 3, 'https://www.blogger.com/video.g?token=AD6v5dy533da99TUVgpWwTXeIZGpRPaICfDP8pYVnJqtfOnLm17tBV-WBPBg8yWrF4PMB4YGVGgVnq92mk6DKXY62W_VtAwQfKbVNC3rwJdgtThq0PUNBEXB2eTLdXObHOtmeJEeOLME', 11),
(34, 1, 'https://www.blogger.com/video.g?token=AD6v5dx5GdvL8lUwBBRBDxUDSqQhL2bH2sehlftytOGvQGMMVH5ZuDLRihhtM2eS9z9MwG8yMWOINg6s8lUG4RTJQSKFWhoKaHk2jx14WmrDPCiITCLhKalJS-pDZxaWAU_VDfrckGGz', 12),
(35, 2, 'https://www.blogger.com/video.g?token=AD6v5dxMrzDI9J4HFrKEWmyR-mcEH7Bses08LC7I5PoO6Q--nYJt2r70roPr9iqcPiVjUH87bhdfKwf6WPjZnYDdqfM0h6AMwdDv_Bhs24rBOoiGR8ej89h67zU0IR1LLgTDB7ckpoA', 12),
(36, 3, 'https://www.blogger.com/video.g?token=AD6v5dxvJurAkyAxsDVvwekCi4WdWKJJQphsiCtMsY4wLPDoiFGuXvOF4W1n-fH5WLY4tKBJUNFsHAMbNKLFc8JGe91SkrarquhAAXjrmmji2PmZlWkZaX995S6iEX3HQVDmjrEitlDe', 12);

-- --------------------------------------------------------

--
-- Estrutura da tabela `stream_filmes`
--

CREATE TABLE `stream_filmes` (
  `id` int(11) NOT NULL,
  `numero` int(11) NOT NULL,
  `streaming_url` text NOT NULL,
  `id_filme` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `stream_filmes`
--

INSERT INTO `stream_filmes` (`id`, `numero`, `streaming_url`, `id_filme`) VALUES
(1, 1, 'https://www.youtube.com/watch?v=gb4wnmZuzmE', 1),
(2, 1, 'https://www.youtube.com/watch?v=AEDOJTyDS2M', 2),
(3, 1, 'https://www.youtube.com/watch?v=1mus2PjX7Y0', 3),
(4, 1, 'https://www.youtube.com/watch?v=fE52R0T6yvY', 4),
(5, 1, 'https://www.youtube.com/watch?v=jJYM_MMU7iY', 5),
(6, 1, 'https://www.youtube.com/watch?v=rxHgdGYeC_0', 6),
(7, 1, 'https://www.youtube.com/watch?v=sXDrm885k74', 7),
(8, 1, 'https://www.youtube.com/watch?v=hOG0PXVivM4', 8),
(9, 1, 'https://www.youtube.com/watch?v=5YhCY_3cNIc', 9),
(10, 1, 'https://www.youtube.com/watch?v=qo4xMoLjbKk', 10),
(11, 1, 'https://www.youtube.com/watch?v=WAUECCFidFE', 11),
(12, 1, 'https://www.youtube.com/watch?v=SdUz-x5oom4', 12);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `animes`
--
ALTER TABLE `animes`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `filmes`
--
ALTER TABLE `filmes`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `stream_animes`
--
ALTER TABLE `stream_animes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_anime` (`id_anime`);

--
-- Índices para tabela `stream_filmes`
--
ALTER TABLE `stream_filmes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_filme` (`id_filme`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `animes`
--
ALTER TABLE `animes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `filmes`
--
ALTER TABLE `filmes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `stream_animes`
--
ALTER TABLE `stream_animes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de tabela `stream_filmes`
--
ALTER TABLE `stream_filmes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `stream_animes`
--
ALTER TABLE `stream_animes`
  ADD CONSTRAINT `stream_animes_ibfk_1` FOREIGN KEY (`id_anime`) REFERENCES `animes` (`id`);

--
-- Limitadores para a tabela `stream_filmes`
--
ALTER TABLE `stream_filmes`
  ADD CONSTRAINT `stream_filmes_ibfk_1` FOREIGN KEY (`id_filme`) REFERENCES `filmes` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
